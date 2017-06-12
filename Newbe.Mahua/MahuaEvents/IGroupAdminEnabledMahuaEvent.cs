using System;
using System.ComponentModel;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// �����¹���Ա�¼�
    /// </summary>
    [Description("�����¹���Ա�¼�")]
    public interface IGroupAdminEnabledMahuaEvent : IMahuaEvent
    {
        /// <summary>
        /// �����¼�
        /// </summary>
        /// <param name="context"></param>
        void ProcessGroupAdminEnabled(GroupAdminEnabledContext context);
    }

    /// <summary>
    /// �¼�������
    /// </summary>
    public class GroupAdminEnabledContext
    {
        /// <summary>
        /// �¼�ʱ��
        /// </summary>
        public DateTime SendTime { get; set; }

        /// <summary>
        /// �¼�����Ⱥ
        /// </summary>
        public string FromGroup { get; set; }

        /// <summary>
        /// ������Ϊ����Ա��QQ
        /// </summary>
        public string ToQq { get; set; }
    }
}