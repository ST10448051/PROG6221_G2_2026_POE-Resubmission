using CyberSecurityAwarenessBot.GUI.Models;

namespace CyberSecurityAwarenessBot.GUI.Services
{
    public class ChatService
    {
        private readonly Random random = new();
        private readonly MemoryService memory = new();
private readonly SentimentService sentiment = new();

        private readonly Dictionary<string, List<string>> responses = new()
        {
            {
                "password",
                new()
                {
                    "Use a strong unique password for every account.",
                    "Consider using a password manager.",
                    "Never reuse passwords across multiple websites."
                }
            },

            {
                "phishing",
                new()
                {
                    "Never click suspicious links.",
                    "Always verify who sent the email.",
                    "Be careful of emails asking for personal information."
                }
            },

            {
                "privacy",
                new()
                {
                    "Review your privacy settings regularly.",
                    "Limit the information you share online.",
                    "Only share personal information with trusted websites."
                }
            },

            {
                "scam",
                new()
                {
                    "If something seems too good to be true, it probably is.",
                    "Scammers often create urgency.",
                    "Never send money without verifying who you're dealing with."
                }
            }
        };

        public Message GetResponse(string input)
        {
            input = input.ToLower();

            foreach (var topic in responses)
            {
                if (input.Contains(topic.Key))
                {
                    memory.RememberTopic(topic.Key);

                    return new Message
                    {
                        Sender = "CyberBot",
                        Text = topic.Value[random.Next(topic.Value.Count)],
                        IsUser = false
                    };
                }
            }

            return new Message
            {
                Sender = "CyberBot",
                Text = "I'm not sure about that. Try asking about passwords, phishing, privacy, or scams.",
                IsUser = false
            };
        }

    }
}