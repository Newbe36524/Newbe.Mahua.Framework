﻿using System;
using System.Collections.Generic;
using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;

namespace Newbe.Mahua.CQP.Commands
{
    internal class DisabledCommandHandler : CommandHandlerBase<DisabledCommand>
    {
        private readonly IEnumerable<IPluginDisabledMahuaEvent> _pluginDisabledMahuaEvents;

        public DisabledCommandHandler(IEnumerable<IPluginDisabledMahuaEvent> pluginDisabledMahuaEvents)
        {
            _pluginDisabledMahuaEvents = pluginDisabledMahuaEvents;
        }

        protected override void HandleCore(DisabledCommand command)
        {
            _pluginDisabledMahuaEvents.Handle(x => x.Disable(new PluginDisabledContext()));
        }
    }

    [Serializable]
    internal class DisabledCommand : CqpCommand
    {
    }
}