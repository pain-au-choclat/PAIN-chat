using NAudio.Wave;

namespace PAIN_chat
{
	class MS_ADPCM : ACM
	{
        public MS_ADPCM()
            : base(new WaveFormat(8000, 16, 1), new AdpcmWaveFormat(8000,1))
        {
        }

        public override string Name => "Microsoft ADPCM";
	}
}
