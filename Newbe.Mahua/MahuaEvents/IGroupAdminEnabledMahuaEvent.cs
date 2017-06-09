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
        void ProcessGroupAdminEnabled(GroupAdminEnabledContext context);
    }

    public class GroupAdminEnabledContext
    {
        public DateTime SendTime { get; set; }
        public string FromGroup { get; set; }
        public string ToQq { get; set; }
    }
}