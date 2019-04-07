using System;

namespace PAIN_chat
{
	interface IAudioReceiver : IDisposable
	{
        void OnReceived(Action<byte[]> handler);
	}
}
