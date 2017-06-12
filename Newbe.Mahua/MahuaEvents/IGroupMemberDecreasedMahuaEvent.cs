using System;
using System.ComponentModel;
using Newbe.Mahua.MahuaEvents.Enums;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// Ⱥ��Ա�����¼�
    /// </summary>
    [Description("Ⱥ��Ա�����¼�")]
    public interface IGroupMemberDecreasedMahuaEvent : IMahuaEvent
    {
        /// <summary>
        /// �����¼�
        /// </summary>
        /// <param name="context"></param>
        void ProcessGroupMemberDecreased(GroupMemberDecreasedContext context);
    }

    /// <summary>
    /// �¼�������
    /// </summary>
    public class GroupMemberDecreasedContext
    {
        /// <summary>
        /// �¼�ʱ��
        /// </summary>
        public DateTime SendTime { get; set; }

        /// <summary>
        /// Ⱥ��Ա����ԭ��
        /// </summary>
        public GroupMemberDecreasedReason GroupMemberDecreasedReason { get; set; }

        /// <summary>
        /// �¼�����Ⱥ
        /// </summary>
        public string FromGroup { get; set; }

        /// <summary>
        /// ��<see cref="GroupMemberDecreasedReason"/>Ϊ<see cref="Enums.GroupMemberDecreasedReason.Kicked"/>���ֵΪ�����Ĺ���ԱQQ������Ϊnull
        /// </summary>
        public string FromQq { get; set; }

        /// <summary>
        /// �뿪��ԱQQ
        /// </summary>
        public string ToQq { get; set; }
    }
}