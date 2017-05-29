using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Newbe.Mahua.Framework.Logging;
using W.Domains;

namespace Newbe.Mahua.Framework
{
    /// <summary>
    /// ���ʵ��������
    /// </summary>
    public static class PluginInstanceManager
    {
        private static IDictionary<string, IPluginLoader> Instances { get; } =
            new Dictionary<string, IPluginLoader>();

        private static readonly ILog Logger = LogProvider.GetLogger(typeof(PluginInstanceManager));


        static PluginInstanceManager()
        {
            Logger.Info("��ʼ���ز��");
            try
            {
                var pluginInfo = GetPluginInfo();
                pluginInfo.ValidateFiles();
                Logger.Debug($"��ǰ�������Ϊ{pluginInfo.Name}");
                var domainLoader = new DomainLoader(pluginInfo.Name, pluginInfo.PluginEntyPointDirectory, true);
                Logger.Debug($"����AppDomain���м��ز��:{pluginInfo.Name}");
                domainLoader.Load();
                Logger.Debug("��ʼ����͸������");
                var loader = domainLoader.Create<IPluginLoader>(typeof(CrossAppDomainPluginLoader).FullName);
                Logger.Debug(
                    $"͸����������ϣ�����Ϊ{loader.GetType().FullName}������ʼ����{nameof(CrossAppDomainPluginLoader.LoadPlugin)}����");
                if (!loader.LoadPlugin(pluginInfo.PluginEntryPointDllFullFilename))
                {
                    throw new PluginLoadException(pluginInfo.Name, loader.Message);
                }
                Instances.Add(pluginInfo.Name, loader);
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
            return "Newbe.Mahua.Plugins.Parrot";
        }


        private static PluginInfo GetPluginInfo()
        {
            var pluginApiExpDll = @"D:\Codes\kq\app\Newbe.Mahua.Plugins.Parrot.dll";
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

        public static IPluginLoader GetInstance()
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