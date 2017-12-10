﻿using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using Newbe.Mahua.MahuaEvents.Enums;
using System.Collections.Generic;

namespace Newbe.Mahua.MPQ.EventFuns
{
    /// <summary>
    /// 某人被管理移除群
    /// </summary>
    public class EventFunHandler2007 : IEventFunHandler
    {
        private readonly IEnumerable<IGroupMemberChangedMahuaEvent> _groupMemberChangedMahuaEvents;
        private readonly IEnumerable<IGroupMemberDecreasedMahuaEvent> _groupMemberDecreasedMahuaEvents;

        public EventFunHandler2007(
            IEnumerable<IGroupMemberChangedMahuaEvent> groupMemberChangedMahuaEvents,
            IEnumerable<IGroupMemberDecreasedMahuaEvent> groupMemberDecreasedMahuaEvents)
        {
            _groupMemberChangedMahuaEvents = groupMemberChangedMahuaEvents;
            _groupMemberDecreasedMahuaEvents = groupMemberDecreasedMahuaEvents;
        }

        public int EventFun { get; } = 2007;

        public void Handle(EventFunInput eventFunInput)
        {
            _groupMemberChangedMahuaEvents
                .Handle(x => x.ProcessGroupMemberChanged(new GroupMemberChangedContext
                {
                    SendTime = Clock.Now,
                    FromGroup = eventFunInput.FromNum,
                    GroupMemberChangedType = GroupMemberChangedType.Decreased,
                    JoinedOrLeftQq = eventFunInput.EventOperator
                }));
            _groupMemberDecreasedMahuaEvents
                .Handle(x => x.ProcessGroupMemberDecreased(new GroupMemberDecreasedContext
                {
                    SendTime = Clock.Now,
                    FromGroup = eventFunInput.FromNum,
                    GroupMemberDecreasedReason = GroupMemberDecreasedReason.Leavebyself,
                    ToQq = eventFunInput.Triggee,
                    FromQq = eventFunInput.EventOperator,
                }));
        }
    }
}