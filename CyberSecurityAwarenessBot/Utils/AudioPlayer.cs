using System.Media;

namespace CyberSecurityAwarenessBot.Utils
{
    public static class AudioPlayer
    {
        public static void PlayGreeting()
        {
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", "greeting.wav");

                if (File.Exists(filePath))
                {
                    SoundPlayer player = new SoundPlayer(filePath);
                    player.PlaySync(); // Wait until the greeting finishes
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Voice greeting file not found.");
                    Console.ResetColor();
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error playing greeting: {ex.Message}");
                Console.ResetColor();
            }
        }
    }
}