using System.Web.Script.Serialization;
using Newbe.Mahua.Framework.Commands;

namespace Newbe.Mahua.Framework
{
    public static class PluginLoaderExtensions
    {
        private static readonly JavaScriptSerializer JavaScriptSerializer = new JavaScriptSerializer();

        private static TResult ConvertType<TResult>(MahuaCommandResult crossDomainCommandResult)
        {
            var json = JavaScriptSerializer.Serialize(crossDomainCommandResult);
            var re = JavaScriptSerializer.Deserialize<TResult>(json);
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