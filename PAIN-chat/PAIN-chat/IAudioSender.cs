using System;

namespace PAIN_chat
{
	interface IAudioSender : IDisposable
	{
        void Send(byte[] payload);
	}
}
