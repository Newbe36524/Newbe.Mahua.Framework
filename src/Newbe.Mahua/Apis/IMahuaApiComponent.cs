﻿using Autofac;
using Newbe.Mahua.MahuaEvents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using IContainer = Autofac.IContainer;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// API输入
    /// </summary>
    public interface IApiInput
    {
    }

    public interface IMahuaApiComponent
    {
    }

    public interface ISendPrivateMessageMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 发送私聊消息
        /// </summary>
        /// <param name="toQq">目标QQ号</param>
        /// <param name="message">消息内容</param>
        [Description("发送私聊消息")]
        void SendPrivateMessage(string toQq, string message);
    }

    public interface ISendGroupMessageMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 发送群消息
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="message">消息内容</param>
        [Description("发送群消息")]
        void SendGroupMessage(string toGroup, string message);
    }

    public interface ISendDiscussMessageMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 发送讨论组消息
        /// </summary>
        /// <param name="toDiscuss">目标讨论组</param>
        /// <param name="message">消息内容</param>
        [Description("发送讨论组消息")]
        void SendDiscussMessage(string toDiscuss, string message);
    }

    public interface ISendLikeMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 发送名片赞
        /// </summary>
        /// <param name="toQq">目标QQ</param>
        /// <returns></returns>
        /// <remarks>:QQ名片赞 10赞每Q每日 至多50人</remarks>
        [Description("发送名片赞")]
        void SendLike(string toQq);
    }

    public interface IGetCookiesMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 取Cookies
        /// </summary>
        /// <returns></returns>
        [Description("取Cookies")]
        string GetCookies();
    }

    public interface IGetBknMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 取bkn
        /// </summary>
        /// <returns>bkn</returns>
        [Description("取bkn")]
        string GetBkn();
    }

    public interface IGetLoginQqMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 取当前登录QQ
        /// </summary>
        /// <returns></returns>
        [Description("取当前登录QQ")]
        string GetLoginQq();
    }

    public interface IGetLoginNickMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 取当前登录QQ昵称
        /// </summary>
        /// <returns></returns>
        [Description("取当前登录QQ昵称")]
        string GetLoginNick();
    }

    public interface IKickGroupMemberMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 移出群成员
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="toQq">目标QQ</param>
        /// <param name="rejectForever">如果为真，则“不再接收此人加群申请”，请慎用</param>
        /// <returns></returns>
        [Description("移出群成员")]
        void KickGroupMember(string toGroup, string toQq, bool rejectForever);
    }

    public interface IBanGroupMemberMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 禁言某群成员
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="toQq">目标QQ</param>
        /// <param name="duration">禁言的时间</param>
        /// <returns></returns>
        [Description("禁言某群成员")]
        void BanGroupMember(string toGroup, string toQq, TimeSpan duration);
    }

    public interface IRemoveBanGroupMemberMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 取消禁言某群成员
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="toQq">目标QQ</param>
        /// <returns></returns>
        [Description("取消禁言某群成员")]
        void RemoveBanGroupMember(string toGroup, string toQq);
    }

    public interface IEnableGroupAdminMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 设置群管理员
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="toQq">被设置的QQ</param>
        /// <returns></returns>
        [Description("设置群管理员")]
        void EnableGroupAdmin(string toGroup, string toQq);
    }

    public interface IDisableGroupAdminMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 删除群管理员
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="toQq">被设置的Q</param>
        /// <returns></returns>
        [Description("删除群管理员")]
        void DisableGroupAdmin(string toGroup, string toQq);
    }

    public interface ISetGroupMemberSpecialTitleMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 设置群成员专属头衔
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="toQq">目标QQ</param>
        /// <param name="specialTitle">如果要删除，这里填空</param>
        /// <param name="duration">专属头衔有效期。如果永久有效，则使用<see cref="TimeSpan.MaxValue"/></param>
        /// <returns></returns>
        [Description("设置群成员专属头衔")]
        void SetGroupMemberSpecialTitle(string toGroup, string toQq, string specialTitle, TimeSpan duration);
    }

    public interface ISetBanAllGroupMembersOptionMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 设置全群禁言
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="enabled">true为启用</param>
        /// <returns></returns>
        [Description("设置全群禁言")]
        void SetBanAllGroupMembersOption(string toGroup, bool enabled);
    }

    public interface IBanGroupAnonymousMemberMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 设置禁言某匿名群员
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="anonymous">匿名名称，<see cref="GroupMessageReceivedContext.FromAnonymous"/>参数</param>
        /// <param name="duration">禁言的时间。不支持解禁</param>
        /// <returns></returns>
        [Description("设置禁言某匿名群员")]
        void BanGroupAnonymousMember(string toGroup, string anonymous, TimeSpan duration);
    }

    public interface ISetGroupAnonymousOptionMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 设置群匿名设置
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="enabled">true为启用</param>
        /// <returns></returns>
        [Description("设置群匿名设置")]
        void SetGroupAnonymousOption(string toGroup, bool enabled);
    }

    public interface ISetGroupMemberCardMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 设置群成员名片
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <param name="toQq">被设置的QQ</param>
        /// <param name="groupMemberCard">群名片</param>
        /// <returns></returns>
        [Description("设置群成员名片")]
        void SetGroupMemberCard(string toGroup, string toQq, string groupMemberCard);
    }

    public interface ILeaveGroupMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 退出群
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <returns></returns>
        [Description("退出群")]
        void LeaveGroup(string toGroup);
    }

    public interface IDissolveGroupMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 解散群
        /// </summary>
        /// <param name="toGroup">目标群</param>
        [Description("解散群")]
        void DissolveGroup(string toGroup);
    }

    public interface ILeaveDiscussMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 退出讨论组
        /// </summary>
        /// <param name="toDiscuss">目标讨论组</param>
        /// <returns></returns>
        [Description("退出讨论组")]
        void LeaveDiscuss(string toDiscuss);
    }

    public interface IAcceptFriendAddingRequestMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 同意添加好友请求
        /// </summary>
        /// <param name="addingFriendRequestId">好友请求Id，<see cref="FriendAddingRequestContext.AddingFriendRequestId"/></param>
        /// <param name="fromQq">发出申请的QQ，<see cref="FriendAddingRequestContext.FromQq"/></param>
        /// <param name="friendRemark">添加后的好友备注</param>
        [Description("同意添加好友请求")]
        void AcceptFriendAddingRequest(string addingFriendRequestId, string fromQq, string friendRemark);
    }

    public interface IRejectFriendAddingRequestMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 拒绝添加好友请求
        /// </summary>
        /// <param name="addingFriendRequestId">好友请求Id，<see cref="FriendAddingRequestContext.SendTime"/></param>
        /// <param name="fromQq">发出申请的QQ，<see cref="FriendAddingRequestContext.FromQq"/></param>
        [Description("拒绝添加好友请求")]
        void RejectFriendAddingRequest(string addingFriendRequestId, string fromQq);
    }

    public interface IAcceptGroupJoiningRequestMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 管理员同意入群申请
        /// </summary>
        /// <param name="groupJoiningRequestId">加入群请求Id，<see cref="GroupJoiningRequestReceivedContext.GroupJoiningRequestId"/></param>
        /// <param name="toGroup">申请加入的群，<see cref="GroupJoiningRequestReceivedContext.ToGroup"/></param>
        /// <param name="fromQq">发出申请的QQ，<see cref="GroupJoiningRequestReceivedContext.FromQq"/></param>
        [Description("管理员同意入群申请")]
        void AcceptGroupJoiningRequest(string groupJoiningRequestId, string toGroup, string fromQq);
    }

    public interface IRejectGroupJoiningRequestMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 管理员拒绝入群申请
        /// </summary>
        /// <param name="groupJoiningRequestId">加入群请求Id，<see cref="GroupJoiningRequestReceivedContext.GroupJoiningRequestId"/></param>
        /// <param name="toGroup">申请加入的群，<see cref="GroupJoiningRequestReceivedContext.ToGroup"/></param>
        /// <param name="fromQq">发出申请的QQ，<see cref="GroupJoiningRequestReceivedContext.FromQq"/></param>
        /// <param name="reason">原因</param>
        [Description("管理员拒绝入群申请")]
        void RejectGroupJoiningRequest(string groupJoiningRequestId, string toGroup, string fromQq, string reason);
    }

    public interface IAcceptGroupJoiningInvitationMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 接受入群邀请
        /// </summary>
        /// <param name="groupJoiningInvitationId">入群邀请Id，<see cref="GroupJoiningInvitationReceivedContext.GroupJoiningInvitationId"/></param>
        /// <param name="toGroup">接受加入的群，<see cref="GroupJoiningInvitationReceivedContext.ToGroup"/></param>
        /// <param name="fromQq">发出接受的QQ，<see cref="GroupJoiningInvitationReceivedContext.FromQq"/></param>
        [Description("接受入群邀请")]
        void AcceptGroupJoiningInvitation(string groupJoiningInvitationId, string toGroup, string fromQq);
    }

    public interface IRejectGroupJoiningInvitationMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 拒绝入群邀请
        /// </summary>
        /// <param name="groupJoiningInvitationId">入群邀请Id，<see cref="GroupJoiningInvitationReceivedContext.GroupJoiningInvitationId"/></param>
        /// <param name="toGroup">接受加入的群，<see cref="GroupJoiningInvitationReceivedContext.ToGroup"/></param>
        /// <param name="fromQq">发出接受的QQ，<see cref="GroupJoiningInvitationReceivedContext.FromQq"/></param>
        /// <param name="reason">原因</param>
        [Description("拒绝入群邀请")]
        void RejectGroupJoiningInvitation(
            string groupJoiningInvitationId,
            string toGroup,
            string fromQq,
            string reason);
    }

    public interface IBanFriendMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 将QQ移入黑名单
        /// </summary>
        /// <param name="toQq"></param>
        [Description("将QQ移入黑名单")]
        void BanFriend(string toQq);
    }

    public interface IRemoveBanFriendMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 将QQ移出黑名单
        /// </summary>
        /// <param name="toQq"></param>
        [Description("将QQ移出黑名单")]
        void RemoveBanFriend(string toQq);
    }

    public interface ISetNoticeMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 发布群公告
        /// </summary>
        /// <param name="toGroup"></param>
        /// <param name="title"></param>
        /// <param name="content"></param>
        [Description("发布群公告")]
        void SetNotice(string toGroup, string title, string content);
    }

    public interface IRemoveFriendMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 删除好友
        /// </summary>
        /// <param name="toQq"></param>
        [Description("删除好友")]
        void RemoveFriend(string toQq);
    }

    public interface IJoinGroupMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 主动加群
        /// </summary>
        /// <param name="toGroup"></param>
        /// <param name="reason"></param>
        [Description("主动加群")]
        void JoinGroup(string toGroup, string reason);
    }

    public interface IGetGroupMemebersWithModelMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 取群成员列表
        /// </summary>
        /// <param name="toGroup">目标群</param>
        /// <returns></returns>
        [Description("取群成员列表")]
        ModelWithSourceString<IEnumerable<GroupMemberInfo>> GetGroupMemebersWithModel(string toGroup);
    }

    public interface IGetGroupsWithModelMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 获取群列表
        /// </summary>
        /// <returns></returns>
        [Description("获取群列表")]
        ModelWithSourceString<IEnumerable<GroupInfo>> GetGroupsWithModel();
    }

    public interface IGetGroupMemebersMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 获取群成员列表（返回字符串）
        /// </summary>
        /// <param name="toGroup"></param>
        /// <returns></returns>
        [Description("获取群成员列表（返回字符串）")]
        string GetGroupMemebers(string toGroup);
    }

    public interface IGetGroupsMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 获取群列表（返回字符串）
        /// </summary>
        /// <returns></returns>
        [Description("获取群列表（返回字符串）")]
        string GetGroups();
    }

    public interface IGetFriendsMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 获取好友列表
        /// </summary>
        /// <returns></returns>
        [Description("获取好友列表")]
        string GetFriends();
    }

    public interface ISendGroupJoiningInvitationMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 发送入群邀请
        /// </summary>
        /// <param name="toQq"></param>
        /// <param name="toGroup"></param>
        [Description("发送入群邀请")]
        void SendGroupJoiningInvitation(string toQq, string toGroup);
    }

    public interface ICreateDiscussMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 创建讨论组
        /// </summary>
        /// <returns>讨论组Id，为空则说明创建失败</returns>
        /// <remarks>每24小时只能创建100个讨论组</remarks>
        [Description("创建讨论组")]
        string CreateDiscuss();
    }

    public interface IKickDiscussMemberMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 踢出讨论组
        /// </summary>
        /// <param name="toDiscuss"></param>
        /// <param name="toQq"></param>
        [Description("踢出讨论组")]
        void KickDiscussMember(string toDiscuss, string toQq);
    }

    public interface ISendDiscussJoiningInvitationMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 发送讨论组邀请
        /// </summary>
        /// <param name="toQq"></param>
        /// <param name="toDiscuss"></param>
        [Description("发送讨论组邀请")]
        void SendDiscussJoiningInvitation(string toQq, string toDiscuss);
    }

    public interface IGetDiscussesMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 获取讨论组列表，使用<see cref="Environment.NewLine"/>分割的讨论组号列表
        /// </summary>
        /// <returns></returns>
        [Description("获取讨论组列表")]
        string GetDiscusses(); // todo 应该再内部就分割好数据
    }

    public interface IContainerMahuaApi : IMahuaApiComponent
    {
        /// <summary>
        /// 获取当前上下文运行的容器
        /// </summary>
        /// <returns></returns>
        [Description("获取当前上下文运行的容器")]
        ILifetimeScope GetLifetimeScope();

        /// <summary>
        /// 设置当前上下文运行的容器
        /// </summary>
        /// <param name="container"></param>
        [Description("设置当前上下文运行的容器")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        void SetLifetimeScope(ILifetimeScope container);

        /// <summary>
        /// 获取全局的容器
        /// </summary>
        /// <returns></returns>
        [Description("获取全局的容器")]
        IContainer GetSourceContainer();

        /// <summary>
        /// 设置全局的容器
        /// </summary>
        /// <param name="container"></param>
        [Description("设置全局的容器")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        void SetSourceContainer(IContainer container);
    }
}
