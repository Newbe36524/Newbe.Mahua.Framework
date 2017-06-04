using System;
using System.Collections.Generic;
using System.IO;
using Newbe.Mahua.Logging;
using W.Domains;

namespace Newbe.Mahua
{
    /// <summary>
    /// ���ʵ��������
    /// </summary>
    public static class PluginInstanceManager
    {
        private static IDictionary<string, IPluginLoader> Instances { get; } =
            new Dictionary<string, IPluginLoader>();

        private static readonly ILog Logger = LogProvider.GetLogger(typeof(PluginInstanceManager));

        private static void LogException(Exception e)
        {
            Logger.ErrorException(e.Message, e);
            Logger.Error(e.StackTrace);
        }


        private static void EnsureAppDomainInitialized(PluginFileInfo pluginFileInfo)
        {
            var pluginInfoName = pluginFileInfo.Name;
            if (Instances.ContainsKey(pluginInfoName))
            {
                return;
            }
            Logger.Info($"��ǰ������ƽ̨Ϊ��{MahuaGlobal.CurrentPlatform:G}");
            Logger.Info("��ʼ���ز��");
            try
            {
                Logger.Debug(pluginFileInfo.ToString());
                Logger.Debug($"��ǰ�������Ϊ{pluginInfoName}");
                var domainLoader = new DomainLoader(pluginInfoName, pluginFileInfo.PluginEntyPointDirectory, true);
                Logger.Debug($"����AppDomain���м��ز��:{pluginInfoName}");
                domainLoader.Load();
                Logger.Debug("��ʼ����͸������");
                var loader = domainLoader.Create<IPluginLoader>(typeof(CrossAppDomainPluginLoader).FullName);
                Logger.Debug(
                    $"͸����������ϣ�����Ϊ{loader.GetType().FullName}������ʼ����{nameof(CrossAppDomainPluginLoader.LoadPlugin)}����");
                if (!loader.LoadPlugin(pluginFileInfo.PluginEntryPointDllFullFilename))
                {
                    throw new PluginLoadException(pluginInfoName, loader.Message);
                }
                Instances.Add(pluginInfoName, loader);
            }
            catch (Exception e)
            {
                var inner = e;
                while (inner != null)
                {
                    LogException(inner);
                    inner = inner.InnerException;
                }
                throw;
            }
        }

        public static IPluginLoader GetInstance(PluginFileInfo pluginFileInfo)
        {
            try
            {
                EnsureAppDomainInitialized(pluginFileInfo);
                return Instances[pluginFileInfo.Name];
            }
            catch (Exception e)
            {
                Logger.ErrorException(e.Message, e);
                throw;
            }
        }
    }
}