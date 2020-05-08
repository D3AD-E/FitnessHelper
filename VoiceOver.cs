using System.Media;
using System.Speech.Synthesis;

namespace FitnessHelper
{
    internal class VoiceOver
    {
        private SpeechSynthesizer synth = new SpeechSynthesizer();

        public enum MessageType
        {
            Pause,
            Resume,
            Rest,
            Time
        }

        public VoiceOver()
        {
            synth.SetOutputToDefaultAudioDevice();
        }

        public void Speak(string message)
        {
            synth.SpeakAsync(message);
        }

        public void Speak(MessageType type, string message = "")
        {
            switch (type)
            {
                case MessageType.Pause:
                    synth.SpeakAsync("Paused");
                    break;

                case MessageType.Resume:
                    synth.SpeakAsync("Resumed");
                    break;

                case MessageType.Rest:
                    synth.SpeakAsync("Rest for" + message + "seconds");
                    break;

                case MessageType.Time:
                    synth.SpeakAsync("for" + message + "seconds");
                    break;
            }
        }

        public void Beep()
        {
            SystemSounds.Beep.Play();
        }
    }
}