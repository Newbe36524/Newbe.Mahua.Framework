﻿using System;
using System.Collections.Generic;
using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using Newbe.Mahua.MahuaEvents.Enums;

namespace Newbe.Mahua.CQP.Commands
{
    internal class GroupAdminChangeCommandHandler : CommandHandlerBase<GroupAdminChangeCommand>
    {
        private readonly IEnumerable<IGroupAdminChangedMahuaEvent> _groupAdminChangedMahuaEvents;
        private readonly IEnumerable<IGroupAdminEnabledMahuaEvent> _groupAdminEnabledMahuaEvents;
        private readonly IEnumerable<IGroupAdminDisabledMahuaEvent> _groupAdminDisabledMahuaEvents;

        public GroupAdminChangeCommandHandler(IEnumerable<IGroupAdminChangedMahuaEvent> groupAdminChangedMahuaEvents,
            IEnumerable<IGroupAdminEnabledMahuaEvent> groupAdminEnabledMahuaEvents,
            IEnumerable<IGroupAdminDisabledMahuaEvent> groupAdminDisabledMahuaEvents)
        {
            _groupAdminChangedMahuaEvents = groupAdminChangedMahuaEvents;
            _groupAdminEnabledMahuaEvents = groupAdminEnabledMahuaEvents;
            _groupAdminDisabledMahuaEvents = groupAdminDisabledMahuaEvents;
        }

        protected override void HandleCore(GroupAdminChangeCommand command)
        {
            _groupAdminChangedMahuaEvents.Handle(x => x.ProcessGroupAdminChange(new GroupAdminChangedContext
            {
                SendTime = command.SendTime,
                ToQq = command.ToQq.ToString(),
                FromGroup = command.FromGroup.ToString(),
                GroupAdminChangeType = command.GroupAdminChangeType
            }));
            switch (command.GroupAdminChangeType)
            {
                case GroupAdminChangeType.Enabled:
                    _groupAdminEnabledMahuaEvents.Handle(
                        x => x.ProcessGroupAdminEnabled(new GroupAdminEnabledContext
                        {
                            SendTime = command.SendTime,
                            FromGroup = command.FromGroup.ToString(),
                            ToQq = command.ToQq.ToString()
                        }));
                    break;
                case GroupAdminChangeType.Disabled:
                    _groupAdminDisabledMahuaEvents.Handle(
                        x => x.ProcessGroupAdminDisabled(new GroupAdminDisabledContext
                        {
                            SendTime = command.SendTime,
                            FromGroup = command.FromGroup.ToString(),
                            ToQq = command.ToQq.ToString(),
                        }));
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }

    [Serializable]
    internal class GroupAdminChangeCommand : CqpCommand
    {
        public GroupAdminChangeType GroupAdminChangeType { get; set; }
        public DateTime SendTime { get; set; }
        public long FromGroup { get; set; }
        public long ToQq { get; set; }
    }
}