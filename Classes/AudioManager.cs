using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Coursework_0._0.Classes
{
    public class AudioManager
    {
        private readonly SoundPlayer audioplayer;
        private const string countdownPath = "../../Resources/SoundEffects/countdown.wav";

        public AudioManager()
        {
            audioplayer = new SoundPlayer();
        }
        private void PlaySound(string soundPath) // plays the sound file using the file path that is passed in as a paramter
        {
            audioplayer.SoundLocation = soundPath;
            audioplayer.Play();
        }
        public void PlayCountdownSound() => PlaySound(countdownPath); //Plays the countdown sound
    }
}
