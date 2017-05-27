using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Newbe.Mahua.Framework.Logging;

namespace Newbe.Mahua.Framework
{
    /// <summary>
    /// ���ʵ��������
    /// </summary>
    public static class PluginInstanceManager
    {
        private static IDictionary<string, CrossAppDomainPluginLoader> Instances { get; } =
            new Dictionary<string, CrossAppDomainPluginLoader>();

        private static readonly ILog Logger = LogProvider.GetLogger(typeof(PluginInstanceManager));


        static PluginInstanceManager()
        {
            Logger.Info("��ʼ���ز��");
            try
            {
                var pluginInfo = GetPluginInfo();
                pluginInfo.ValidateFiles();
                Logger.Debug($"��ǰ�������Ϊ{pluginInfo.Name}");
                var appDomainSetup = new AppDomainSetup
                {
                    DisallowBindingRedirects = false,
                    ApplicationBase = pluginInfo.PluginEntyPointDirectory
                };
                if (File.Exists(pluginInfo.PluginEntryPointConfigFullFilename))
                {
                    appDomainSetup.ConfigurationFile = pluginInfo.PluginEntryPointConfigFullFilename;
                }
                Logger.Debug($"����AppDomain���м��ز��:{pluginInfo.Name}");
                var domain = AppDomain.CreateDomain(pluginInfo.Name, AppDomain.CurrentDomain.Evidence,
                    appDomainSetup);
                domain.Load(new AssemblyName
                {
                    CodeBase = pluginInfo.PluginEntryPointDllFullFilename,
                });
                Logger.Debug("��ʼ����͸������");
                var objectHandle = domain.CreateInstanceFrom("Newbe.Mahua.Framework.PluginLoader.dll",
                    typeof(CrossAppDomainPluginLoader).FullName);
                var loader = (CrossAppDomainPluginLoader) objectHandle.Unwrap();
                Logger.Debug(
                    $"͸����������ϣ�����Ϊ{loader.GetType().FullName}������ʼ����{nameof(CrossAppDomainPluginLoader.LoadPlugin)}����");
                if (!loader.LoadPlugin(pluginInfo.PluginEntryPointDllFullFilename))
                {
                    throw new PluginLoadException(pluginInfo.Name, loader.Message);
                }
                Instances.Add(pluginInfo.Name, loader);
                IPluginInfo plugin = loader;
                Logger.Debug($"����������:{pluginInfo.Name},AppId:{plugin.Id},ApiVersion:{plugin.Version}");
            }
            catch (Exception e)
            {
                Logger.ErrorException(e.Message, e);
                var inner = e.InnerException;
                while (inner != null)
                {
                    Logger.ErrorException(e.Message, e);
                    inner = inner.InnerException;
                }
                throw;
            }
        }

        private static string GetPluginName()
        {
            return Path.GetFileNameWithoutExtension(typeof(PluginInstanceManager).Assembly.CodeBase);
        }


        private static PluginInfo GetPluginInfo()
        {
            var pluginApiExpDll = typeof(PluginInstanceManager).Assembly.CodeBase;
            var pluginName = Path.GetFileNameWithoutExtension(pluginApiExpDll);
            var baseDir = AppDomain.CurrentDomain.BaseDirectory;
            var dllDir = Path.GetFullPath(Path.Combine(baseDir, pluginName));
            var re = new PluginInfo
            {
                Name = pluginName,
                PluginApiExporterRuntimeFullpath = pluginApiExpDll,
                PluginEntyPointDirectory = dllDir,
                PluginEntryPointDllFullFilename = Path.Combine(dllDir, $"{pluginName}.dll"),
                PluginEntryPointConfigFullFilename = Path.Combine(dllDir, $"{pluginName}.dll.config"),
            };
            return re;
        }

        internal static IPluginBase GetInstance()
        {
            try
            {
                return Instances[GetPluginName()];
            }
            catch (Exception e)
            {
                Logger.ErrorException(e.Message, e);
                throw;
            }
        }
    }
}