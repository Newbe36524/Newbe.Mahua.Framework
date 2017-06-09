﻿using System;
using System.ComponentModel;

namespace Newbe.Mahua.MahuaEvents
{
    /// <summary>
    /// 讨论组消息接受事件
    /// </summary>
    [Description("讨论组消息接受事件")]
    public interface IDiscussMessageReceivedMahuaEvent : IMahuaEvent
    {
        void ProcessDiscussGroupMessageReceived(DiscussMessageReceivedMahuaEventContext context);
    }

    public class DiscussMessageReceivedMahuaEventContext
    {
        public DateTime SendTime { get; set; }
        public string FromDiscuss { get; set; }
        public string FromQq { get; set; }
        public string Message { get; set; }
    }
}