﻿using Newbe.Mahua.Apis;
using Newbe.Mahua.CQP.NativeApi;
using System;

namespace Newbe.Mahua.CQP.Apis
{
    public class SendPrivateMessageApiMahuaCommandHandler : CqpApiCommandHandlerBase<SendPrivateMessageApiMahuaCommand>
    {
        public SendPrivateMessageApiMahuaCommandHandler(
            ICoolQApi coolQApi,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
            : base(coolQApi, cqpAuthCodeContainer)
        {
        }

        public override void Handle(SendPrivateMessageApiMahuaCommand message)
        {
            CoolQApi.CQ_sendPrivateMsg(AuthCode, Convert.ToInt64(message.ToQq), message.Message);
        }
    }
}
