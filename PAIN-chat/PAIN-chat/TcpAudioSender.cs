using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace PAIN_chat
{
    class TcpAudioSender : IAudioSender
    {
        private readonly TcpClient tcpSender;
        public TcpAudioSender(IPEndPoint endPoint)
        {
            try
            {
                tcpSender = new TcpClient();
                tcpSender.Connect(endPoint);
            }
            catch
            {
                MessageBox.Show("The connection timed out");
            }
        }

        public void Send(byte[] payload)
        {
            try
            {
                tcpSender.Client.Send(payload);
            }
            catch
            {

            }
        }

        public void Dispose()
        {
            tcpSender?.Close();
        }
    }
}
