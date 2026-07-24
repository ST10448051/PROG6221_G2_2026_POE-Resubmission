namespace CyberSecurityAwarenessBot.Data
{
    public class ResponseManager
    {
        private readonly Random random = new Random();

        private readonly Dictionary<string, List<string>> responses = new()
        {
            {
                "password",
                new List<string>
                {
                    "Use a unique password for every account.",
                    "Use at least 12 characters with letters, numbers and symbols.",
                    "Consider using a password manager to generate strong passwords."
                }
            },

            {
                "phishing",
                new List<string>
                {
                    "Never click suspicious email links.",
                    "Always check the sender's email address carefully.",
                    "If something feels suspicious, contact the company directly."
                }
            },

            {
                "privacy",
                new List<string>
                {
                    "Review your privacy settings regularly.",
                    "Don't share personal information publicly.",
                    "Only give websites the information they actually need."
                }
            },

            {
                "scam",
                new List<string>
                {
                    "Scammers often create urgency to pressure you.",
                    "Never send money to someone you don't trust.",
                    "If it sounds too good to be true, it probably is."
                }
            },

            {
                "safe browsing",
                new List<string>
                {
                    "Only visit websites using HTTPS.",
                    "Keep your browser updated.",
                    "Avoid downloading files from unknown websites."
                }
            },

            {
                "malware",
                new List<string>
                 {

                    "Install antivirus software and keep it updated.",
                    "Never download software from unknown websites.",
                    "Keep Windows updated to protect against malware."
                }
            },

            {
                "virus",
                new List<string>
                {
                    "Computer viruses spread through infected files.",
                    "Avoid opening unknown email attachments.",
                    "Keep your antivirus software updated."
                }
            },

            {
                "2fa",
                new List<string>
                {
                    "Two-factor authentication adds an extra layer of security.",
                    "Always enable 2FA where possible.",
                    "Authenticator apps are generally safer than SMS verification."
                }
            }

        };

        public string? GetResponse(string input)
        {
            input = input.ToLower();

            // Greetings
            if (input.Contains("hello") || input.Contains("hi"))
                return "Hello! It's great to meet you. How can I help keep you safe online today?";

            if (input.Contains("how are you"))
                return "I'm doing great, thank you for asking! I'm here to help you stay safe online.";

            if (input.Contains("purpose"))
                return "My purpose is to teach cybersecurity awareness and help you stay safe online.";

            if (input.Contains("what can i ask"))
                return "You can ask me about passwords, phishing, scams, privacy and safe browsing.";

            foreach (var topic in responses)
            {
                if (input.Contains(topic.Key))
                {
                    return topic.Value[random.Next(topic.Value.Count)];
                }
            }

            return null;
        }
    }
}