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
        void ProcessGroupAdminDisabled(GroupAdminDisabledContext context);
    }

    public class GroupAdminDisabledContext
    {
        public DateTime SendTime { get; set; }
        public long FromGroup { get; set; }
        public long ToQq { get; set; }
    }
}