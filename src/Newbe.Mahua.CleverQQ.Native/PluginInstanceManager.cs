﻿namespace Newbe.Mahua.CleverQQ.Native
{
    internal static class PluginInstanceManager
    {
        public static IPluginLoader GetInstance()
        {
            var pluginInfo = PluginInfoProvider.GetPluginInfo();
            return Mahua.PluginInstanceManager.GetInstance(pluginInfo);
        }
    }
}
