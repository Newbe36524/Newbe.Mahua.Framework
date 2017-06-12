using System;
using System.ComponentModel;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// ���Ⱥ����Ա�¼�
    /// </summary>
    [Description("���Ⱥ����Ա�¼�")]
    public interface IGroupAdminDisabledMahuaEvent : IMahuaEvent
    {
        /// <summary>
        /// �����¼�
        /// </summary>
        /// <param name="context"></param>
        void ProcessGroupAdminDisabled(GroupAdminDisabledContext context);
    }

    /// <summary>
    /// �¼�������
    /// </summary>
    public class GroupAdminDisabledContext
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
        /// ���������Ա��QQ
        /// </summary>
        public string ToQq { get; set; }
    }
}