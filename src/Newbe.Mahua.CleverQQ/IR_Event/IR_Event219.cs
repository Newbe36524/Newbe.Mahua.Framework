﻿namespace Newbe.Mahua.CleverQQ.IR_Event
{
    /// <summary>
    /// 某人已被邀请入群
    /// 群主或管理员邀请成员加群或开启了群成员100以内无需审核或无需审核直接进群，被邀请人同意进群后才会触发
    /// </summary>
    public class IR_Event219 : IIR_Event
    {
        public int IR_Event { get; } = 219;

        public void Handle(IR_EventInput eventFunInput)
        {
            // todo not supported
        }
    }
}
