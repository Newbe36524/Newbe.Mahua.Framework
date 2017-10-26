﻿using Autofac;
using Autofac.Features.Variance;
using MediatR;
using Newbe.Mahua.Commands;
using Newbe.Mahua.Internals;
using Newbe.Mahua.Logging;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Lifetime;

namespace Newbe.Mahua
{
    public class CrossAppDomainPluginLoader : MarshalByRefObject, IPluginLoader
    {
        private static readonly ILog Logger = LogProvider.For<CrossAppDomainPluginLoader>();
        private IContainer _container;

        private static void Debug(string msg)
        {
            Logger.Debug(msg);
#if CrossDomainLog
            //%temp%/Newbe.Mahua.log
            File.AppendAllLines(Path.Combine(Path.GetTempPath(), "Newbe.Mahua.log"), new[] { msg });
#endif
        }

        public override object InitializeLifetimeService()
        {
            var lease = (ILease)base.InitializeLifetimeService();
            System.Diagnostics.Debug.Assert(lease != null, "lease != null");
            if (lease.CurrentState == LeaseState.Initial)
            {
                lease.InitialLeaseTime = TimeSpan.FromSeconds(0);
            }
            return lease;
        }

        public string Message { get; private set; }

        public bool LoadPlugin(string pluginEntryPointDllFullFilename)
        {
            Debug($"当前AppDomain:{AppDomain.CurrentDomain.FriendlyName}，开始加载插件程序集：{pluginEntryPointDllFullFilename}");
            try
            {
                Assembly.Load(new AssemblyName
                {
                    CodeBase = pluginEntryPointDllFullFilename,
                });
                foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
                {
                    Debug($"当前已加载程序集:{assembly.FullName}");
                }
                Debug($"程序集加载完毕,开始构建Container");
                var superBuilder = new ContainerBuilder();
                superBuilder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies()).AsImplementedInterfaces()
                    .AsSelf();
                var superContainer = superBuilder.Build();
                var subBuilderRegisters = superContainer.Resolve<IMahuaModule[]>().ToArray();
                var builder = new ContainerBuilder();
                foreach (var autofacContainerBuilder in subBuilderRegisters)
                {
                    var modules = autofacContainerBuilder.GetModules();
                    foreach (var module in modules)
                    {
                        builder.RegisterModule(module);
                    }
                }
                // enables contravariant Resolve() for interfaces with single contravariant ("in") arg
                builder
                    .RegisterSource(new ContravariantRegistrationSource());

                // mediator itself
                builder
                    .RegisterType<Mediator>()
                    .As<IMediator>()
                    .InstancePerLifetimeScope();

                // request handlers
                builder
                    .Register<SingleInstanceFactory>(ctx =>
                    {
                        var c = ctx.Resolve<IComponentContext>();
                        return t =>
                        {
                            object o;
                            return c.TryResolve(t, out o) ? o : null;
                        };
                    })
                    .InstancePerLifetimeScope();

                // notification handlers
                builder
                    .Register<MultiInstanceFactory>(ctx =>
                    {
                        var c = ctx.Resolve<IComponentContext>();
                        return t => (IEnumerable<object>)c.Resolve(typeof(IEnumerable<>).MakeGenericType(t));
                    })
                    .InstancePerLifetimeScope();


                var container = builder.Build();
                Debug("构建Container完毕。");
                _container = container;
                return true;
            }
            catch (Exception ex)
            {
                Message = ex.Message;
                return false;
            }
        }

        private static readonly ConcurrentDictionary<string, Type> CommandAndResultTypes =
            new ConcurrentDictionary<string, Type>();

        private static Type GetMahuaType(string typeName, MahuaPlatform? mahuaPlatform = null)
        {
            var p = mahuaPlatform ?? MahuaGlobal.CurrentPlatform;
            var re = CommandAndResultTypes.GetOrAdd($"{typeName}, Newbe.Mahua.{p:G}",
                typeStr => Type.GetType(typeStr, true, true));
            return re;
        }


        private static readonly ConcurrentDictionary<Type, Func<object, object[], object>> WithResultHandlers =
            new ConcurrentDictionary<Type, Func<object, object[], object>>();

        public string Handle(string commandJson, string cmdTypeFullName, string resultTypeFullName)
        {
            WriteDiagnostics(() => commandJson);
            using (var beginLifetimeScope = _container.BeginLifetimeScope())
            {
                SetContainer(beginLifetimeScope);
                var center = beginLifetimeScope.Resolve<ICommandCenter>();
                var cmdTypeType = GetMahuaType(cmdTypeFullName);
                System.Diagnostics.Debug.Assert(cmdTypeType != null, "cmdTypeType != null");
                var handler = WithResultHandlers.GetOrAdd(cmdTypeType, typeof(ICommandCenter)
                    .GetMethod(nameof(ICommandCenter.HandleWithResult))
                    .MakeGenericMethod(cmdTypeType, GetMahuaType(resultTypeFullName))
                    .Invoke);
                var re = handler(center,
                    new[] { GlobalCache.JavaScriptSerializer.Deserialize(commandJson, cmdTypeType) });
                var rejson = GlobalCache.JavaScriptSerializer.Serialize(re);
                WriteDiagnostics(() => rejson);
                return rejson;
            }
        }


        private static readonly ConcurrentDictionary<Type, Func<object, object[], object>> VoidResultHandlers =
            new ConcurrentDictionary<Type, Func<object, object[], object>>();

        public void Handle(string commandJson, string cmdTypeFullName)
        {
            WriteDiagnostics(() => commandJson);
            using (var beginLifetimeScope = _container.BeginLifetimeScope())
            {
                SetContainer(beginLifetimeScope);
                var center = beginLifetimeScope.Resolve<ICommandCenter>();
                var cmdTypeType = GetMahuaType(cmdTypeFullName);
                System.Diagnostics.Debug.Assert(cmdTypeType != null, "cmdTypeType != null");
                var handler = VoidResultHandlers.GetOrAdd(cmdTypeType, typeof(ICommandCenter)
                    .GetMethod(nameof(ICommandCenter.Handle))
                    .MakeGenericMethod(cmdTypeType).Invoke);
                handler(center, new[] { GlobalCache.JavaScriptSerializer.Deserialize(commandJson, cmdTypeType) });
            }
        }

        private static void WriteDiagnostics(Func<object> action)
        {
            if (MahuaGlobal.DiagnosticsConvertion.EnableDiagnostics)
            {
                var re = action?.Invoke();
                if (re != null)
                {
                    var s = re as string;
                    Debug(s ?? $"{re.GetType().FullName} {GlobalCache.JavaScriptSerializer.Serialize(re)}");
                }
            }
        }

        private static void SetContainer(ILifetimeScope container)
        {
            var api = container.Resolve<IMahuaApi>();
            api.SetContainer(container);
        }
    }
}
