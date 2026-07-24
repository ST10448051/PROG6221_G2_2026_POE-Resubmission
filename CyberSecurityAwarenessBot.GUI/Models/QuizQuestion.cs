namespace CyberSecurityAwarenessBot.GUI.Models
{
    public class QuizQuestion
    {
        public string Question { get; set; } = "";

        public List<string> Answers { get; set; } = new();

        public int CorrectAnswer { get; set; }

        public string Explanation { get; set; } = "";

        public string Category { get; set; } = "";
        public string[] Options { get; internal set; }
    }
}