﻿using Newbe.Mahua.Apis;
using Newbe.Mahua.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class SendPrivateMessageApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<SendPrivateMessageApiMahuaCommand, SendPrivateMessageApiMahuaCommandResult>
    {
        public SendPrivateMessageApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IRobotSessionContext robotSessionContext,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override SendPrivateMessageApiMahuaCommandResult Handle(SendPrivateMessageApiMahuaCommand message)
        {
            MpqApi.Api_SendMsg(CurrentQq, 1, 0, null, message.ToQq, message.Message);
            var re = new SendPrivateMessageApiMahuaCommandResult
            {
                MessageId = -1
            };
            return re;
        }
    }
}
