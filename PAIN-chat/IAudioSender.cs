using System;

namespace PAIN_chat
{
	interface IAudioSender : IDisposable
	{
        void send(byte[] payload);
	}
}
