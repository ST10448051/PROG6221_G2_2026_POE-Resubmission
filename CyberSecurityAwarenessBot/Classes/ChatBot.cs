using CyberSecurityAwarenessBot.Data;
using CyberSecurityAwarenessBot.Utils;

namespace CyberSecurityAwarenessBot.Classes
{
    public class ChatBot
    {
        private readonly User currentUser = new();
        private readonly ResponseManager responseManager = new();

        public void Start()
        {
            Console.Title = "Cybersecurity Awareness Chatbot";

            ConsoleHelper.SetTheme();

            AudioPlayer.PlayGreeting();

            Logo.Display();

            ConsoleHelper.DrawDivider();

            Console.WriteLine("Welcome to the Cybersecurity Awareness Chatbot!");
            Console.WriteLine();

            AskName();

            ChatLoop();
        }

        private void AskName()
        {
            ConsoleHelper.DrawDivider();

            Console.Write("Enter your name: ");

            string? name = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(name))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Please enter a valid name: ");
                Console.ResetColor();

                name = Console.ReadLine();
            }

            currentUser.Name = name.Trim();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nHello {currentUser.Name}! 👋");
            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine("You can ask me about:");
            Console.WriteLine("- Passwords");
            Console.WriteLine("- Phishing");
            Console.WriteLine("- Privacy");
            Console.WriteLine("- Scams");
            Console.WriteLine("- Safe Browsing");
            Console.WriteLine();
            Console.WriteLine("Type 'help' to see this list again.");
            Console.WriteLine("Type 'exit' to quit.");
            Console.WriteLine();
        }

        private void ChatLoop()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"👤 {currentUser.Name} > ");
                Console.ResetColor();

                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a question.");
                    Console.ResetColor();
                    continue;
                }

                input = input.Trim();

                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Thank you for using the Cybersecurity Awareness Chatbot!");
                    Console.ResetColor();
                    break;
                }

                if (input.Equals("help", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine();
                    Console.WriteLine("Topics:");
                    Console.WriteLine("- Password");
                    Console.WriteLine("- Phishing");
                    Console.WriteLine("- Scam");
                    Console.WriteLine("- Privacy");
                    Console.WriteLine("- Safe Browsing");
                    Console.WriteLine();
                    continue;
                }

                string? response = responseManager.GetResponse(input);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("🤖 CyberBot > ");
                Console.ResetColor();

                if (response != null)
                {
                    AnimationHelper.TypeWrite(response);
                }
                else
                {
                    AnimationHelper.TypeWrite("I'm sorry, I don't understand that. Could you rephrase your question?");
                }

                Console.WriteLine();
            }
        }

        private void TypeWriter(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(15);
            }

            Console.WriteLine();
        }
    }
}