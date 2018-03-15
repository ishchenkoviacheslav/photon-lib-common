
using System;

namespace TestPhotonLib.Common.CustomEventArgs
{
    public class ChatMessageEventArgs: EventArgs
    {
        public string Message { get; private set; }
        public ChatMessageEventArgs(string message)
        {
            Message = message;
        }
    }
}
