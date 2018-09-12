﻿using Newbe.Mahua.Apis;
using Newbe.Mahua.CleverQQ.NativeApi;

namespace Newbe.Mahua.CleverQQ.Apis
{
    public class GetFriendsApiMahuaCommandHandler
        : CleverQQApiMahuaCommandHandlerBase<GetFriendsApiMahuaCommand, GetFriendsApiMahuaCommandResult>
    {
        public GetFriendsApiMahuaCommandHandler(
            ICleverQQApi cleverqqApi,
            IRobotSessionContext robotSessionContext,
            IIR_EventOutput eventFunOutput)
            : base(cleverqqApi, robotSessionContext, eventFunOutput)
        {
        }

        public override GetFriendsApiMahuaCommandResult Handle(GetFriendsApiMahuaCommand message)
        {
            var friendsString = CleverQQApi.Api_GetFriendList(CurrentQq);
            var re = new GetFriendsApiMahuaCommandResult
            {
                FriendsString = friendsString
            };
            return re;
        }
    }
}
