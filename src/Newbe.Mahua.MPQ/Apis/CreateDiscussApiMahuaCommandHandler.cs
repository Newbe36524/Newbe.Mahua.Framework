﻿using Newbe.Mahua.Apis;
using Newbe.Mahua.MPQ.NativeApi;

namespace Newbe.Mahua.MPQ.Apis
{
    public class CreateDiscussApiMahuaCommandHandler
        : MpqApiMahuaCommandHandlerBase<CreateDiscussApiMahuaCommand, CreateDiscussApiMahuaCommandResult>
    {
        public CreateDiscussApiMahuaCommandHandler(
            IMpqApi mpqApi,
            IQqSession qqSession,
            IEventFunOutput eventFunOutput)
            : base(mpqApi, qqSession, eventFunOutput)
        {
        }

        public override CreateDiscussApiMahuaCommandResult Handle(CreateDiscussApiMahuaCommand message)
        {
            var discussId = MpqApi.Api_CreateDG(CurrentQq);
            var re = new CreateDiscussApiMahuaCommandResult
            {
                DiscussId = discussId
            };
            return re;
        }
    }
}
