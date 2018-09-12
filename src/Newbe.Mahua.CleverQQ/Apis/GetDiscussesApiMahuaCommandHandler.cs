﻿using Newbe.Mahua.Apis;
using Newbe.Mahua.CleverQQ.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class GetDiscussesApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<GetDiscussesApiMahuaCommand, GetDiscussesApiMahuaCommandResult>
    {
        public GetDiscussesApiMahuaCommandHandler(
            ICleverQQApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIR_EventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override GetDiscussesApiMahuaCommandResult Handle(GetDiscussesApiMahuaCommand message)
        {
            var discussesString = CleverQQApi.Api_GetDisGroupList(CurrentQq);
            var re = new GetDiscussesApiMahuaCommandResult
            {
                DiscussesString = discussesString
            };
            return re;
        }
    }
}
