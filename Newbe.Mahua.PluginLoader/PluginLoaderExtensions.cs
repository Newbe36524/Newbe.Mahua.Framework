using Newbe.Mahua.Commands;
using Newbe.Mahua.Internals;

namespace Newbe.Mahua
{
    public static class PluginLoaderExtensions
    {
        private static TResult ConvertType<TResult>(MahuaCommandResult crossDomainCommandResult)
        {
            var json = GlobalCache.JavaScriptSerializer.Serialize(crossDomainCommandResult);
            var re = GlobalCache.JavaScriptSerializer.Deserialize<TResult>(json);
            return re;
        }

        public static TResult SendCommand<TResult>(this IPluginLoader pluginLoader, MahuaCommand command)
            where TResult : MahuaCommandResult, new()
        {
            MahuaCommandResult result;
            pluginLoader.SendCommandWithResult(command, out result);
            //todo ��AppDomainʱ������ǿ��ת��ʧ�ܵ����⣬��˲�����json���л��İ취
            var re = ConvertType<TResult>(result);
            return re;
        }
    }
}