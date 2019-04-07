using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace PAIN_chat
{
    class TcpAudioReceiver : IAudioReceiver
    {
        private readonly TcpListener listener;
        private Action<byte[]> handler;
        private bool listening;

        public TcpAudioReceiver(int portNumber)
        {
            var endPoint = new IPEndPoint(IPAddress.Any, portNumber);
            listener = new TcpListener(endPoint);
            listener.Start();
            listening = true;
            ThreadPool.QueueUserWorkItem(ListenerThread, null);
        }

        public void OnReceived(Action<byte[]> onAudioReceivedAction)
        {
            handler = onAudioReceivedAction;
        }

        private void ListenerThread(object state)
        {
            var incomingBuffer = new byte[1024 * 16];
            try
            {
                while(listening)
                {
                    using (var client = listener.AcceptTcpClient())
                    {
                        while (listening)
                        {
                            int received = client.Client.Receive(incomingBuffer);
                            var b = new byte[received];
                            Buffer.BlockCopy(incomingBuffer, 0, b, 0, received);
                            handler?.Invoke(b);
                        }
                    }
                }
            }
            catch(SocketException)
            {
                //Disconnected
            }
        }

        public void Dispose()
        {
            listening = false;
            listener?.Stop();
        }
    }
}
