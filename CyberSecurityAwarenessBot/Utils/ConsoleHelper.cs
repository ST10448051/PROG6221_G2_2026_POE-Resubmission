namespace CyberSecurityAwarenessBot.Utils
{
    public static class ConsoleHelper
    {
        public static void SetTheme()
        {
            Console.Title = "Cybersecurity Awareness Chatbot";

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Clear();
        }

        public static void DrawDivider()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(new string('═', 70));
            Console.ResetColor();
        }

    }
}