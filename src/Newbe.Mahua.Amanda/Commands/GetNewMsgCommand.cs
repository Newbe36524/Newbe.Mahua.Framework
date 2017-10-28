﻿using Newbe.Mahua.Commands;
using Newbe.Mahua.MahuaEvents;
using Newbe.Mahua.MahuaEvents.Enums;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Newbe.Mahua.Amanda.Commands
{
    internal class GetNewMsgCommandHandler : ICommandHandler<GetNewMsgCommand>
    {
        private readonly IEnumerable<IPrivateMessageReceivedMahuaEvent> _privateMessageReceivedMahuaEvents;

        private readonly IEnumerable<IPrivateMessageFromFriendReceivedMahuaEvent>
            _privateMessageFromFriendReceivedMahuaEvents;

        private readonly IEnumerable<IPrivateMessageFromOnlineReceivedMahuaEvent>
            _privateMessageFromOnlineReceivedMahuaEvents;

        private readonly IEnumerable<IPrivateMessageFromGroupReceivedMahuaEvent>
            _privateMessageFromGroupReceivedMahuaEvents;

        private readonly IEnumerable<IPrivateMessageFromDiscussReceivedMahuaEvent>
            _privateMessageFromDiscussGroupReceivedMahuaEvents;

        private readonly IEnumerable<IGroupMessageReceivedMahuaEvent> _groupMessageReceivedMahuaEvents;

        private readonly IEnumerable<IDiscussMessageReceivedMahuaEvent> _discussMessageReceivedMahuaEvents;

        public GetNewMsgCommandHandler(
            IEnumerable<IPrivateMessageReceivedMahuaEvent> privateMessageReceivedMahuaEvents,
            IEnumerable<IPrivateMessageFromFriendReceivedMahuaEvent> privateMessageFromFriendReceivedMahuaEvents,
            IEnumerable<IPrivateMessageFromOnlineReceivedMahuaEvent> privateMessageFromOnlineReceivedMahuaEvents,
            IEnumerable<IPrivateMessageFromGroupReceivedMahuaEvent> privateMessageFromGroupReceivedMahuaEvents,
            IEnumerable<IPrivateMessageFromDiscussReceivedMahuaEvent> privateMessageFromDiscussGroupReceivedMahuaEvents,
            IEnumerable<IGroupMessageReceivedMahuaEvent> groupMessageReceivedMahuaEvents,
            IEnumerable<IDiscussMessageReceivedMahuaEvent> discussMessageReceivedMahuaEvents
        )
        {
            _privateMessageReceivedMahuaEvents = privateMessageReceivedMahuaEvents;
            _privateMessageFromFriendReceivedMahuaEvents = privateMessageFromFriendReceivedMahuaEvents;
            _privateMessageFromOnlineReceivedMahuaEvents = privateMessageFromOnlineReceivedMahuaEvents;
            _privateMessageFromGroupReceivedMahuaEvents = privateMessageFromGroupReceivedMahuaEvents;
            _privateMessageFromDiscussGroupReceivedMahuaEvents = privateMessageFromDiscussGroupReceivedMahuaEvents;
            _groupMessageReceivedMahuaEvents = groupMessageReceivedMahuaEvents;
            _discussMessageReceivedMahuaEvents = discussMessageReceivedMahuaEvents;
        }

        private static PrivateMessageFromType ConvertType(FromMessageType source)
        {
            switch (source)
            {
                case FromMessageType.好友消息:
                    return PrivateMessageFromType.Friend;
                case FromMessageType.群临时消息:
                    return PrivateMessageFromType.Group;
                case FromMessageType.讨论组临时消息:
                    return PrivateMessageFromType.DiscussGroup;
                case FromMessageType.Unknown:
                case FromMessageType.讨论组消息:
                case FromMessageType.群消息:
                    return PrivateMessageFromType.Unknown;
                default:
                    throw new ArgumentOutOfRangeException(nameof(source), source, null);
            }
        }

        public void Handle(GetNewMsgCommand command)
        {
            var sendTime = DateTime.Now;
            var commandFromqq = command.Fromqq;
            if (command.Type == FromMessageType.Unknown)
            {
                //todo
                return;
            }
            if (command.Type == FromMessageType.群消息)
            {
                _groupMessageReceivedMahuaEvents.Handle(x => x.ProcessGroupMessage(new GroupMessageReceivedContext
                {
                    Message = command.Message,
                    FromQq = commandFromqq,
                    FromGroup = command.Fromgroup,
                    SendTime = sendTime
                }));
                return;
            }
            if (command.Type == FromMessageType.讨论组消息)
            {
                _discussMessageReceivedMahuaEvents.Handle(x => x.ProcessDiscussGroupMessageReceived(
                    new DiscussMessageReceivedMahuaEventContext
                    {
                        Message = command.Message,
                        FromQq = commandFromqq,
                        FromDiscuss = command.Fromgroup,
                        SendTime = sendTime
                    }));
                return;
            }
            var type = ConvertType(command.Type);
            _privateMessageReceivedMahuaEvents.Handle(x =>
            {
                x.ProcessPrivateMessage(new PrivateMessageReceivedContext
                {
                    SendTime = sendTime,
                    FromQq = commandFromqq,
                    Message = command.Message,
                    PrivateMessageFromType = type,
                });
            });
            switch (type)
            {
                case PrivateMessageFromType.Unknown:
                    break;
                case PrivateMessageFromType.Friend:
                    _privateMessageFromFriendReceivedMahuaEvents.Handle(x => x.ProcessFriendMessage(
                        new PrivateMessageFromFriendReceivedContext
                        {
                            SendTime = sendTime,
                            FromQq = commandFromqq,
                            Message = command.Message
                        }));
                    break;
                case PrivateMessageFromType.Online:
                    _privateMessageFromOnlineReceivedMahuaEvents.Handle(x => x.ProcessOnlineMessage(
                        new PrivateMessageFromOnlineReceivedContext
                        {
                            SendTime = sendTime,
                            FromQq = commandFromqq,
                            Message = command.Message,
                        }));
                    break;
                case PrivateMessageFromType.Group:
                    _privateMessageFromGroupReceivedMahuaEvents.Handle(x => x.ProcessGroupMessage(
                        new PrivateMessageFromGroupReceivedContext
                        {
                            SendTime = sendTime,
                            Message = command.Message,
                            FromGroup = command.Fromgroup,
                            FromQq = commandFromqq
                        }));
                    break;
                case PrivateMessageFromType.DiscussGroup:
                    _privateMessageFromDiscussGroupReceivedMahuaEvents.Handle(x => x.ProcessDiscussGroupMessage(
                        new PrivateMessageFromDiscussReceivedContext
                        {
                            SendTime = sendTime,
                            Message = command.Message,
                            FromDiscuss = command.Fromgroup,
                            FromQq = commandFromqq
                        }));
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }

    [DataContract]
    public class GetNewMsgCommand : AmandaCommand
    {
        [DataMember]
        public FromMessageType Type { get; set; }

        [DataMember]
        public string Fromgroup { get; set; }

        [DataMember]
        public string Fromqq { get; set; }

        [DataMember]
        public string Message { get; set; }
    }

    public enum FromMessageType
    {
        Unknown,
        好友消息,
        群消息,
        群临时消息,
        讨论组消息,
        讨论组临时消息,
    }
}
