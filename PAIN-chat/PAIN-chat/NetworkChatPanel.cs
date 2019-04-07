using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Data;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using NAudio.Wave;

namespace PAIN_chat
{
    public partial class NetworkChatPanel : Form
    {
        private INetworkChatCodec selectedCodec;
        private volatile bool connected;
        private NetworkAudioPlayer player;
        private NetworkAudioSender audioSender;

        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);

        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);

        public NetworkChatPanel()
        {
            // Use reflection to find all the codecs
            var codecs = ReflectionHelperInstances.CreatAllInstancesOf<INetworkChatCodec>();

            InitializeComponent();
            PopulateInputDevicesCombo();
            PopulateCodecsCombo(codecs);
            comboBoxProtocol.Items.Add("UDP");
            comboBoxProtocol.Items.Add("TCP");
            comboBoxProtocol.SelectedIndex = 0;
            Disposed += OnPanelDisposed;

            // InitializeComponent();
            uint CurrVol = 0;
            waveOutGetVolume(IntPtr.Zero, out CurrVol);
            ushort CalcVol = (ushort)(CurrVol & 0x0000FFFF);
            trackBar1.Value = CalcVol / (ushort.MaxValue / 10);
        }
        
        void OnPanelDisposed(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void PopulateCodecsCombo(IEnumerable<INetworkChatCodec> codecs)
        {
            var sorted = from codec in codecs
                         where codec.IsAvailable
                         orderby codec.BitsPerSecond ascending
                         select codec;

            foreach(var codec in sorted)
            {
                var bitRate = codec.BitsPerSecond == -1 ? "VBR" : $"{codec.BitsPerSecond / 1000.0:0.#}kbps";
                var text = $"{codec.Name} ({bitRate})";
                comboBoxCodecs.Items.Add(new CodecComboItem { Text = text, Codec = codec });
            }
            comboBoxCodecs.SelectedIndex = 1;
        }

        class CodecComboItem
        {
            public string Text { get; set; }
            public INetworkChatCodec Codec { get; set; }
            public override string ToString()
            {
                return Text;
            }
        }

        private void PopulateInputDevicesCombo()
        {
            for(int n = 0; n < WaveIn.DeviceCount; n++)
            {
                var capabilities = WaveIn.GetCapabilities(n);
                comboBoxInputDevices.Items.Add(capabilities.ProductName);
            }
            if(comboBoxInputDevices.Items.Count > 0)
            {
                comboBoxInputDevices.SelectedIndex = 0;
            }
        }

        private void buttonStartStreaming_Click_1(object sender, EventArgs e)
        {
            if(!connected)
            {
                if (textBoxPort.Text == "")
                {
                    MessageBox.Show("Please provide correct port");
                    textBoxPort.Text = "0000";
                }

                string portS = textBoxPort.Text;  
                int port = Int32.Parse(portS);

                if (port > 65535)
                {
                    textBoxPort.Text = "65535";
                }
                else
                {
                    try
                    {
                        IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(textBoxIPAddress.Text), int.Parse(textBoxPort.Text));
                        int inputDeviceNumber = comboBoxInputDevices.SelectedIndex;
                        selectedCodec = ((CodecComboItem)comboBoxCodecs.SelectedItem).Codec;
                        Connect(endPoint, inputDeviceNumber, selectedCodec);
                        buttonStartStreaming.Text = "Disconnect";
                    }
                    catch
                    {
                        MessageBox.Show("Please provide correct IP address");
                    }
                }
            }
            else
            {
                Disconnect();
                buttonStartStreaming.Text = "Connect";
            }
        }

        private void Connect(IPEndPoint endPoint, int inputDeviceNumber, INetworkChatCodec codec)
        {
            var receiver = (comboBoxProtocol.SelectedIndex == 0)
                ? (IAudioReceiver)new UdpAudioReceiver(endPoint.Port)
                : new TcpAudioReceiver(endPoint.Port);
            var sender = (comboBoxProtocol.SelectedIndex == 0)
                ? (IAudioSender)new UdpAudioSender(endPoint)
                : new TcpAudioSender(endPoint);

            player = new NetworkAudioPlayer(codec, receiver);
            audioSender = new NetworkAudioSender(codec, inputDeviceNumber, sender);
            connected = true;
        }

        private void Disconnect()
        {
            if (connected)
            {
                connected = false;

                player.Dispose();
                audioSender.Dispose();
                selectedCodec.Dispose();
                new NetworkChatPanel();
                saveIpPort();
                System.Windows.Forms.Application.Restart();
            }
        }

        private void saveIpPort()
        {
            Properties.Settings.Default.IP = textBoxIPAddress.Text;
            Properties.Settings.Default.Port = textBoxPort.Text;
            Properties.Settings.Default.Save();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int newVolume = ((ushort.MaxValue / 10) * trackBar1.Value);
            uint NewVolumeAllChannels = (((uint)newVolume & 0x0000ffff) | ((uint)newVolume << 16));
            waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);

        }
    }
}
