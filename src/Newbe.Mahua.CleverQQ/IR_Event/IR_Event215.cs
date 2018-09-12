﻿using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using Newbe.Mahua.MahuaEvents.Enums;
using System.Collections.Generic;

namespace Newbe.Mahua.CleverQQ.IR_Event
{
    /// <summary>
    /// 某人被邀请加入群
    /// </summary>
    public class IR_Event215 : IIR_Event
    {
        private readonly IEnumerable<IGroupMemberChangedMahuaEvent> _groupMemberChangedMahuaEvents;
        private readonly IEnumerable<IGroupMemberIncreasedMahuaEvent> _groupMemberIncreasedMahuaEvents;

        public IR_Event215(
            IEnumerable<IGroupMemberChangedMahuaEvent> groupMemberChangedMahuaEvents,
            IEnumerable<IGroupMemberIncreasedMahuaEvent> groupMemberIncreasedMahuaEvents)
        {
            _groupMemberChangedMahuaEvents = groupMemberChangedMahuaEvents;
            _groupMemberIncreasedMahuaEvents = groupMemberIncreasedMahuaEvents;
        }

        public int IR_Event { get; } = 215;

        public void Handle(IR_EventInput eventFunInput)
        {
            _groupMemberChangedMahuaEvents
                .Handle(x => x.ProcessGroupMemberChanged(new GroupMemberChangedContext
                {
                    SendTime = Clock.Now,
                    FromGroup = eventFunInput.FromNum,
                    GroupMemberChangedType = GroupMemberChangedType.Increased,
                    JoinedOrLeftQq = eventFunInput.Triggee
                }));
            _groupMemberIncreasedMahuaEvents
                .Handle(x => x.ProcessGroupMemberIncreased(new GroupMemberIncreasedContext
                {
                    SendTime = Clock.Now,
                    FromGroup = eventFunInput.FromNum,
                    GroupMemberIncreasedReason = GroupMemberIncreasedReason.GroupMemberInvitated,
                    InvitatorOrAdmin = eventFunInput.EventOperator,
                    JoinedQq = eventFunInput.Triggee
                }));
        }
    }
}
