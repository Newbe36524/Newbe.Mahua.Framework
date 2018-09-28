﻿using Newbe.Mahua.Messages.Steps;
using System.IO;
using System.Linq;
using Newbe.Mahua.NativeApi;
using Newbe.Mahua.Messages;

namespace Newbe.Mahua.MPQ.Messages
{
    public class DiscussMessageDone : IDiscussMessageDone, IWithCancelable
    {
        private readonly IMahuaApi _mahuaApi;
        private readonly IMpqMessage _message;
        private readonly IMpqApi _mpqApi;
        private readonly IRobotSessionContext _robotSessionContext;

        public DiscussMessageDone(
            IMahuaApi mahuaApi,
            IMpqMessage message,
            IMpqApi mpqApi,
            IRobotSessionContext robotSessionContext)
        {
            _mahuaApi = mahuaApi;
            _message = message;
            _mpqApi = mpqApi;
            _robotSessionContext = robotSessionContext;
        }

        public void Done()
        {
            var msg = _message.GetMessage();
            if (_message.Images.Any())
            {
                _message.Images.Upload(file =>
                    _mpqApi.Api_UploadPic(
                        _robotSessionContext.CurrentQq,
                        2,
                        _message.Target,
                        File.ReadAllBytes(file)));
                msg = _message.Images.Formate(msg);
            }
            _mahuaApi.SendPrivateMessage(_message.Target, msg);
        }

        public void WithCancelToken(IMessageCancelToken token)
        {
            var msg = _message.GetMessage();
            if (_message.Images.Any())
            {
                _message.Images.Upload(file =>
                    _mpqApi.Api_UploadPic(
                        _robotSessionContext.CurrentQq,
                        2,
                        _message.Target,
                        File.ReadAllBytes(file)));
                msg = _message.Images.Formate(msg);
            }
            _mahuaApi.SendPrivateMessage(_message.Target, msg, token);
        }
    }
}
