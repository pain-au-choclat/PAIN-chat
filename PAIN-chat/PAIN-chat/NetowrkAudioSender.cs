using System;
using System.Windows.Forms;
using NAudio.Wave;

namespace PAIN_chat
{

    class NetworkAudioSender
    {
        private readonly INetworkChatCodec codec;
        private readonly IAudioSender audioSender;
        private readonly WaveIn waveIn;
        public int inputVol, temp;
        Timer inputBuffer = new Timer { Interval = 500, Enabled = false };

        public NetworkAudioSender(INetworkChatCodec codec, int inputDeviceNumber, IAudioSender audioSender)
        {
            this.codec = codec;
            this.audioSender = audioSender;
            
            waveIn = new WaveIn();
            
            waveIn.BufferMilliseconds = 50;
            waveIn.DeviceNumber = inputDeviceNumber;
            waveIn.WaveFormat = codec.RecordFormat;
            waveIn.DataAvailable += OnAudioCaptured;
            waveIn.StartRecording();
            
        }

        private void OnAudioCaptured(object sender, WaveInEventArgs e)
        {

            for (int i = 0; i < e.BytesRecorded; i += 2)
            {
                short sample = (short)((e.Buffer[i + 1] << 8) |
                                        e.Buffer[i + 0]);
                float sample32 = sample / 32768f;

                //Audio converted to db value.
                double sampleD = (double)sample32;
                sampleD = 20 * Math.Log10(Math.Abs(sampleD));
                temp = (int)sampleD + 100;

                //Filter to remove nonsensical db outputs
                if (temp > 0 && temp < 100)
                {
                    inputVol = temp;
                }
                else
                {
                    //ignore
                }
            }

            //Microphone input sensitivty, controlled via scroll bar
            //500ms buffer using timer to stop choppy audio output
            if (inputVol > NetworkChatPanel.inputSens)
            {
                inputBuffer.Enabled = true;
                inputBuffer.Tick += new EventHandler(BufferTimeout);
                
            }
            if(inputBuffer.Enabled)
            {
                byte[] encoded = codec.Encode(e.Buffer, 0, e.BytesRecorded);
                audioSender.Send(encoded);
            }
        }

        private void BufferTimeout(object sender, EventArgs e)
        {
            inputBuffer.Enabled = false;
        }

        public void Dispose()
        {
            waveIn.DataAvailable -= OnAudioCaptured;
            waveIn.StopRecording();
            waveIn.Dispose();
            waveIn?.Dispose();
            audioSender?.Dispose();
        }
    }
}
