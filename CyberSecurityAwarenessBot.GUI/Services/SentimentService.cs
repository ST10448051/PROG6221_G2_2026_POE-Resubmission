namespace CyberSecurityAwarenessBot.GUI.Services
{
    public class SentimentService
    {
        public string? DetectEmotion(string input)
        {
            input = input.ToLower();

            if (input.Contains("worried") ||
                input.Contains("scared") ||
                input.Contains("afraid"))
            {
                return "I understand why you're concerned. Cybersecurity can seem overwhelming, but I'm here to help.";
            }

            if (input.Contains("confused") ||
                input.Contains("don't understand"))
            {
                return "No problem! I'll explain it as simply as I can.";
            }

            if (input.Contains("happy") ||
                input.Contains("thanks"))
            {
                return "You're very welcome! 😊";
            }

            return null;
        }
    }
}