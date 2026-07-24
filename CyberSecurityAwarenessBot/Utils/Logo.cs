namespace CyberSecurityAwarenessBot.Utils
{
    public static class Logo
    {
        public static void Display()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("===============================================================");
            Console.WriteLine("   ██████╗██╗   ██╗██████╗ ███████╗██████╗ ");
            Console.WriteLine("  ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗");
            Console.WriteLine("  ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝");
            Console.WriteLine("  ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗");
            Console.WriteLine("  ╚██████╗   ██║   ██████╔╝███████╗██║  ██║");
            Console.WriteLine("   ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝");
            Console.WriteLine();
            Console.WriteLine("        CYBERSECURITY AWARENESS CHATBOT");
            Console.WriteLine("===============================================================");

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("════════════════════════════════════════════════════");
            Console.WriteLine("        Stay Safe. Stay Smart. Stay Secure.");
            Console.WriteLine("════════════════════════════════════════════════════");

            Console.ResetColor();
        }
    }
}