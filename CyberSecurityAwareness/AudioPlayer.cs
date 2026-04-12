// Voice greeting implemented
using System;
using System.IO;      // For File.Exists and Path.Combine
using System.Media;   // For SoundPlayer

namespace CyberSecurityAwareness
{
    internal class AudioPlayer
    {
        // Name of your audio file
        private const string WavFileName = "greeting.wav";

        public static void PlayVoiceGreeting()
        {
            // Path to the file inside the "assets" folder
            string wavPath = Path.Combine("assets", WavFileName);

            // Check if file exists
            if (!File.Exists(wavPath))
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"\n[Voice greeting: place '{WavFileName}' in the 'assets' folder to enable audio.]\n");
                Console.ResetColor();
                return;
            }

            try
            {
                // Play the sound
                using (SoundPlayer player = new SoundPlayer(wavPath))
                {
                    player.PlaySync(); // waits until sound finishes
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n[Error playing audio: {ex.Message}]\n");
                Console.ResetColor();
            }
        }
    }
}