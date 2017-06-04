# Newbe.Mahua.Framework

dev                                                                              | master
-------------------------------------------------------------------------------- | -----------------------------------------------------------------------------------
![build:](https://travis-ci.org/Newbe36524/Newbe.Mahua.Framework.svg?branch=dev) | ![build:](https://travis-ci.org/Newbe36524/Newbe.Mahua.Framework.svg?branch=master)

## 你打麻花，谁疼？麻花疼。

本SDK为实现QQ机器人平台的大一统，全新实现支持以下高级特性：

- 支持多种机器人平台：酷Q、MyPCQQ、Amanda等
- 支持Framework452
- 支持依赖注入

你只要基于SDK的接口开发一次，便可以将你的插件发布到所有支持的QQ机器人平台。

[点击此处，加入QQ群一起讨论吧](http://shang.qq.com/wpa/qunwpa?idkey=62199995e33f098e64625f54d213a3e00ed0fb01f71d839a11e7186a92b03fa6)

## 名词表

中文    | 英文                     | 说明
----- | ---------------------- | ------------------
QQ    | QQ                     |
群     | Group                  |
群成员   | GroupMember            |
讨论组   | Discuss                |
好友    | Friend                 |
好友申请  | FriendAddingRequest    |
入群申请  | GroupJoiningRequest    |
加群邀请  | GroupJoiningInvitation |
私聊消息  | PrivateMessage         |
群消息   | GroupMessage           |
讨论组消息 | DiscussMessage         |
机器人平台 | Platform               | 酷Q、Amanda、MyPCQQ等等
插件    | Plugin                 |

## MahuaEvent支持列表

事件                                           | 说明               | CQP | MPQ
-------------------------------------------- | ---------------- | --- | ---
IDiscussMessageReceivedMahuaEvent            | 讨论组消息接受事件        | √   |
IFriendAddedMahuaEvent                       | 已添加新好友事件         | √   |
IFriendAddingRequestMahuaEvent               | 好友申请接受事件         | √   |
IGroupAdminChangedMahuaEvent                 | 群管理员变更事件         | √   |
IGroupAdminDisabledMahuaEvent                | 解除群管理员事件         | √   |
IGroupAdminEnabledMahuaEvent                 | 任命新管理员事件         | √   |
IGroupJoiningInvitationReceivedMahuaEvent    | 入群邀请接收事件         | √   |
IGroupJoiningRequestReceivedMahuaEvent       | 入群申请接收事件         | √   |
IGroupMemberChangedMahuaEvent                | 群成员变更事件          | √   |
IGroupMemberDecreasedMahuaEvent              | 群成员减少事件          | √   |
IGroupMemberIncreasedMahuaEvent              | 群成员增多事件          | √   |
IGroupMessageReceivedMahuaEvent              | 群消息接收事件          | √   |
IGroupUploadedMahuaEvent                     | 群文件上传事件          | √   |
IPlatfromExitedMahuaEvent                    | 机器人平台退出事件        | √   |
IPluginDisabledMahuaEvent                    | 插件被禁用事件          | √   |
IPluginEnabledMahuaEvent                     | 插件被启用事件          | √   |
IPrivateMessageFromDiscussReceivedMahuaEvent | 来自讨论组成员的私聊消息接收事件 | √   |
IPrivateMessageFromFriendReceivedMahuaEvent  | 来自好友的私聊消息接收事件    | √   |
IPrivateMessageFromGroupReceivedMahuaEvent   | 来自群成员的私聊消息接收事件   | √   |
IPrivateMessageFromOnlineReceivedMahuaEvent  | 来自在线状态的私聊消息接收事件  | √   |
IPrivateMessageReceivedMahuaEvent            | 私聊消息接收事件         | √   |

## MahuaApi支持列表

Api                          | 说明             | CQP | MPQ
---------------------------- | -------------- | --- | ---
SendPrivateMessage           | 发送私聊消息         | √   | √
SendGroupMessage             | 发送群消息          | √   | √
SendDiscussMessage           | 发送讨论组消息        | √   | √
SendLike                     | 发送名片赞          | √   | √
GetCookies                   | 取Cookies       | √   | √
GetCsrfToken                 | 取CsrfToken，bkn | √   | √
GetLoginQq                   | 取当前登录QQ        | √   | √
GetLoginNick                 | 取当前登录QQ昵称      | √   | √
GetRecord                    | 接收语音           | √   | √
KickGroupMember              | 移出群成员          | √   | √
BanGroupMember               | 禁言某群成员         | √   | √
RemoveBanGroupMember         | 取消禁言某群成员       | √   | √
EnableGroupAdmin             | 设置群管理员         | √   | √
DisableGroupAdmin            | 删除群管理员         | √   | √
SetGroupMemberSpecialTitle   | 设置群成员专属头衔      | √   | √
SetBanAllGroupMembersOption  | 设置全群禁言         | √   | √
SetGroupAnonymousBan         | 设置禁言某匿名群员      | √   | √
SetGroupAnonymousOption      | 设置群匿名设置        | √   | √
SetGroupMemberCard           | 设置群成员名片        | √   | √
LeaveGroup                   | 退出群            | √   | √
DissolveGroup                | 解散群            | √   | √
LeaveDiscuss                 | 退出讨论组          | √   | √
AcceptFriendAddingRequest    | 同意添加好友请求       | √   | √
RejectFriendAddingRequest    | 拒绝添加好友请求       | √   | √
AcceptGroupJoiningRequest    | 管理员同意入群申请      | √   | √
RejectGroupJoiningRequest    | 管理员拒绝入群申请      | √   | √
AcceptGroupJoiningInvitation | 接受入群邀请         | √   | √
RejectGroupJoiningInvitation | 拒绝入群邀请         | √   | √
