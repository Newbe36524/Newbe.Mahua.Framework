﻿using Newbe.Mahua.Apis;
using Newbe.Mahua.CQP.NativeApi;
using System;

namespace Newbe.Mahua.CQP.Apis
{
    internal class LeaveGroupApiMahuaMahuaCommandHandler
        : CqpApiMahuaCommandHandlerBase<LeaveGroupApiMahuaCommand>
    {
        public LeaveGroupApiMahuaMahuaCommandHandler(
            ICoolQApi coolQApi,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
            : base(coolQApi, cqpAuthCodeContainer)
        {
        }

        public override void Handle(LeaveGroupApiMahuaCommand message)
        {
            CoolQApi.CQ_setGroupLeave(AuthCode, Convert.ToInt64(message.ToGroup), false);
        }
    }
}
