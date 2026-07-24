using CyberSecurityAwarenessBot.GUI.Models;

namespace CyberSecurityAwarenessBot.GUI.Services
{
    public class QuizService
    {
        private readonly List<QuizQuestion> questions = new();

        public QuizService()
        {
            questions.Add(new QuizQuestion
            {
                Question = "Which password is strongest?",
                Options = new[]
                {
            "Password123",
            "qwerty",
            "12345678",
            "C!9z#LmP@72"
        },
                CorrectAnswer = 3,
                Explanation = "Strong passwords are long and contain mixed characters."
            });

            questions.Add(new QuizQuestion
            {
                Question = "What is phishing?",
                Options = new[]
                {
            "A type of computer hardware",
            "A cyberattack that tricks users into revealing information",
            "A secure email service",
            "A firewall"
        },
                CorrectAnswer = 1,
                Explanation = "Phishing attempts to trick users into revealing sensitive information."
            });

            questions.Add(new QuizQuestion
            {
                Question = "What should you do if you receive a suspicious email?",
                Options = new[]
                {
            "Click all links to investigate",
            "Reply with your details",
            "Delete it or report it",
            "Forward it to everyone"
        },
                CorrectAnswer = 2,
                Explanation = "Suspicious emails should be deleted or reported."
            });

            questions.Add(new QuizQuestion
            {
                Question = "Why should you enable Multi-Factor Authentication (MFA)?",
                Options = new[]
                {
            "It makes passwords shorter",
            "It adds an extra layer of security",
            "It removes the need for passwords",
            "It speeds up your computer"
        },
                CorrectAnswer = 1,
                Explanation = "MFA provides additional protection even if a password is compromised."
            });

            questions.Add(new QuizQuestion
            {
                Question = "Which of these is a sign of a scam website?",
                Options = new[]
                {
            "HTTPS encryption",
            "Professional design",
            "Many spelling mistakes and strange URLs",
            "Clear contact information"
        },
                CorrectAnswer = 2,
                Explanation = "Scam websites often contain spelling mistakes and suspicious URLs."
            });

            questions.Add(new QuizQuestion
            {
                Question = "What should you do before downloading software?",
                Options = new[]
                {
            "Check the source is trustworthy",
            "Disable antivirus",
            "Ignore reviews",
            "Download from any website"
        },
                CorrectAnswer = 0,
                Explanation = "Always download software from trusted sources."
            });

            questions.Add(new QuizQuestion
            {
                Question = "What is malware?",
                Options = new[]
                {
            "Helpful software updates",
            "Software designed to harm devices or steal data",
            "A password manager",
            "A web browser"
        },
                CorrectAnswer = 1,
                Explanation = "Malware is malicious software designed to cause damage or steal information."
            });

            questions.Add(new QuizQuestion
            {
                Question = "Why are software updates important?",
                Options = new[]
                {
            "They only change colors",
            "They often contain security fixes",
            "They make passwords unnecessary",
            "They reduce internet speed"
        },
                CorrectAnswer = 1,
                Explanation = "Updates frequently patch security vulnerabilities."
            });

            questions.Add(new QuizQuestion
            {
                Question = "What information should you avoid sharing publicly online?",
                Options = new[]
                {
            "Your favourite movie",
            "Public news articles",
            "Sensitive personal information",
            "Weather updates"
        },
                CorrectAnswer = 2,
                Explanation = "Personal information can be used by cybercriminals."
            });

            questions.Add(new QuizQuestion
            {
                Question = "What should you do if you suspect your account has been hacked?",
                Options = new[]
                {
            "Ignore it",
            "Change your password immediately",
            "Post about it online",
            "Delete your computer files"
        },
                CorrectAnswer = 1,
                Explanation = "Changing your password quickly can help secure your account."
            });

            questions.Add(new QuizQuestion
            {
                Question = "Which Wi-Fi network is safest to use?",
                Options = new[]
                {
            "An open public Wi-Fi",
            "A Wi-Fi named 'Free Internet'",
            "A secured network requiring a password",
            "Any network with the strongest signal"
        },
                CorrectAnswer = 2,
                Explanation = "Password-protected Wi-Fi networks are generally more secure."
            });
        }

        public QuizQuestion GetQuestion(int index)
        {
            return questions[index];
        }

        public int Count => questions.Count;
    }
}