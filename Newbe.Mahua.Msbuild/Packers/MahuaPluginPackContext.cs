namespace Newbe.Mahua.Msbuild.Packers
{
    public class MahuaPluginPackContext
    {
        /// <summary>
        /// ��Ŀ�ļ���
        /// </summary>
        public string ProjectDirectory { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public string Configuration { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        public string NewbePluginName { get; set; }

        /// <summary>
        /// Package�ļ���
        /// </summary>
        public string PackageDirectory { get; set; }
    }
}