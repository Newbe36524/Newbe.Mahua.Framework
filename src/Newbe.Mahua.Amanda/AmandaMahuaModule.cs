﻿using Autofac;
using Newbe.Mahua.Amanda.Apis;
using Newbe.Mahua.Amanda.Commands;
using Newbe.Mahua.Apis;

namespace Newbe.Mahua.Amanda
{
    public class AmandaMahuaModule : IMahuaModule
    {
        Module[] IMahuaModule.GetModules()
        {
            return new Module[]
            {
                new AmandaApiModule(),
                new AmandaCommandHandlerModule(),
                new ApiCommandHandlersModule()
            };
        }

        private class AmandaCommandHandlerModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<AddFrinendCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<AddGroupCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<AdminChangeCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<BecomeFriendsCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<GetNewMsgCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<GetQqWalletDataCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<GroupMemberDecreaseCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<GroupMemberIncreaseCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<InformationCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<InitializationCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<ConfigurationManagerCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<PluginStartCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<PluginStopCommandHandler>().AsImplementedInterfaces();
                builder.RegisterType<UpdataCookiesCommandHandler>().AsImplementedInterfaces();
            }
        }

        private class ApiCommandHandlersModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterMahuaApi<AcceptFriendAddingRequestApiMahuaCommandHandler, AcceptFriendAddingRequestApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<AcceptGroupJoiningInvitationApiMahuaCommandHandler, AcceptGroupJoiningInvitationApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<AcceptGroupJoiningRequestApiMahuaCommandHandler, AcceptGroupJoiningRequestApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<BanGroupMemberApiMahuaCommandHandler, BanGroupMemberApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<DisableGroupAdminApiMahuaCommandHandler, DisableGroupAdminApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<DissolveGroupApiMahuaCommandHandler, DissolveGroupApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<EnableGroupAdminApiMahuaCommandHandler, EnableGroupAdminApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<GetBknApiMahuaCommandHandler, GetBknApiMahuaCommand, GetBknApiMahuaCommandResult>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<GetCookiesApiMahuaCommandHandler, GetCookiesApiMahuaCommand, GetCookiesApiMahuaCommandResult>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<GetFriendsApiMahuaCommandHandler, GetFriendsApiMahuaCommand, GetFriendsApiMahuaCommandResult>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<GetGroupMemebersApiMahuaCommandHandler, GetGroupMemebersApiMahuaCommand, GetGroupMemebersApiMahuaCommandResult>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<GetGroupsApiMahuaCommandHandler, GetGroupsApiMahuaCommand, GetGroupsApiMahuaCommandResult>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<GetLoginNickApiMahuaCommandHandler, GetLoginNickApiMahuaCommand, GetLoginNickApiMahuaCommandResult>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<GetLoginQqApiMahuaCommandHandler, GetLoginQqApiMahuaCommand, GetLoginQqApiMahuaCommandResult>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<JoinGroupApiMahuaCommandHandler, JoinGroupApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<KickGroupMemberApiMahuaCommandHandler, KickGroupMemberApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<LeaveDiscussApiMahuaCommandHandler, LeaveDiscussApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<LeaveGroupApiMahuaCommandHandler, LeaveGroupApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<RejectFriendAddingRequestApiMahuaCommandHandler, RejectFriendAddingRequestApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<RejectGroupJoiningInvitationApiMahuaCommandHandler, RejectGroupJoiningInvitationApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<RejectGroupJoiningRequestApiMahuaCommandHandler, RejectGroupJoiningRequestApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<RemoveBanGroupMemberApiMahuaCommandHandler, RemoveBanGroupMemberApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<RemoveFriendApiMahuaCommandHandler, RemoveFriendApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<SendDiscussMessageApiMahuaCommandHandler, SendDiscussMessageApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<SendGroupMessageApiMahuaCommandHandler, SendGroupMessageApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<SendLikeApiMahuaCommandHandler, SendLikeApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<SendPrivateMessageApiMahuaCommandHandler, SendPrivateMessageApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<SetBanAllGroupMembersOptionApiMahuaCommandHandler, SetBanAllGroupMembersOptionApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<SetGroupAnonymousOptionApiMahuaCommandHandler, SetGroupAnonymousOptionApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
                builder.RegisterMahuaApi<SetGroupMemberCardApiMahuaCommandHandler, SetGroupMemberCardApiMahuaCommand>(MahuaGlobal.DefaultApiHandlerAuthorName);
            }
        }

        private class AmandaApiModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
            }
        }
    }
}
