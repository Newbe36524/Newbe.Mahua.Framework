﻿using System;
using Newbe.Mahua.Commands;
using Newbe.Mahua.MPQ.NativeApi;

namespace Newbe.Mahua.MPQ.Commands
{
    internal class EventFunCommandHandler : CommandHandlerBase<EventFunCommand>
    {
        private readonly IQqContainer _qqContainer;

        public EventFunCommandHandler(IQqContainer qqContainer)
        {
            _qqContainer = qqContainer;
        }

        protected override void HandleCore(EventFunCommand command)
        {
            _qqContainer.ReceivedQq = command.ReceiverQq;
            throw new NotImplementedException();
        }
    }

    [Serializable]
    internal class EventFunCommand : MqpCommand
    {
        public long ReceiverQq { get; set; }
        public int EventType { get; set; }
        public int EventAdditionType { get; set; }
        public long FromNum { get; set; }
        public string EventOperator { get; set; }
        public string Triggee { get; set; }
        public string Message { get; set; }
        public string RawMessage { get; set; }
    }

    [Serializable]
    internal class EventFunCommandResult : MahuaCommandResult
    {
        public int ResultCode { get; set; }
    }
}