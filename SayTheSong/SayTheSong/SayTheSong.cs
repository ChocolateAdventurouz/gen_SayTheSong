using System;
using System.Windows.Forms;
using Daniel15.Sharpamp;
using SpeechLib;
namespace SayTheSong
{
    public class SayTheSong : Daniel15.Sharpamp.GeneralPlugin
    {
        public override string Name
        {
            get { return "SayTheSong"; }
        }

        public override void Initialize()
        {
            Winamp.SongChanged += Winamp_SongChanged;
        }


        public override void Config()
        {

            MessageBox.Show("...");
        }
        void Winamp_SongChanged(object sender, Daniel15.Sharpamp.SongChangedEventArgs e)
        {
            SpVoice spVoice = new SpVoice();
            if (e.Song.HasMetadata == true)
            {
                spVoice.Speak("Now Playing" + e.Song.Title + "With" + e.Song.Artist, SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak);
            }
            else
            {
                spVoice.Speak("Now Playing" + e.Song.Title, SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak);
            }

        }
    }
}
