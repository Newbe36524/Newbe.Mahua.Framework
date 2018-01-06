﻿using Newbe.Mahua.Apis;
using Newbe.Mahua.CQP.NativeApi;

namespace Newbe.Mahua.CQP.Apis
{
    public class GetLoginQqApiMahuaCommandHandler
        : CqpApiCommandHandlerBase<GetLoginQqApiMahuaCommand, GetLoginQqApiMahuaCommandResult>
    {
        public GetLoginQqApiMahuaCommandHandler(
            ICoolQApi coolQApi,
            ICqpAuthCodeContainer cqpAuthCodeContainer)
            : base(coolQApi, cqpAuthCodeContainer)
        {
        }

        public override GetLoginQqApiMahuaCommandResult Handle(GetLoginQqApiMahuaCommand message)
        {
            var qq = CoolQApi.CQ_getLoginQQ(AuthCode).ToString();
            return new GetLoginQqApiMahuaCommandResult
            {
                Qq = qq
            };
        }
    }
}
