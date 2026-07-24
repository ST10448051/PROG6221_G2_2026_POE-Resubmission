using CyberSecurityAwarenessBot.GUI.Services;
using System.Windows;

namespace CyberSecurityAwarenessBot.GUI.Views
{
    public partial class QuizWindow : Window
    {
        private readonly QuizService quiz = new();

        private int currentQuestion = 0;
        private int score = 0;

        public QuizWindow()
        {
            InitializeComponent();
            LoadQuestion();
            ActivityLogService.AddLog("Quiz started");
        }

        private void LoadQuestion()
        {
            var q = quiz.GetQuestion(currentQuestion);

            QuestionNumber.Text =
                $"Question {currentQuestion + 1} of {quiz.Count}";

            QuestionText.Text = q.Question;

            AnswerList.ItemsSource = q.Options;
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (AnswerList.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an answer first.");
                return;
            }

            var q = quiz.GetQuestion(currentQuestion);

            if (AnswerList.SelectedIndex == q.CorrectAnswer)
            {
                score++;
            }

            currentQuestion++;

            if (currentQuestion >= quiz.Count)
            {
                MessageBox.Show(
                    $"Quiz Complete!\n\nScore: {score}/{quiz.Count}",
                    "Results");
                ActivityLogService.AddLog(
                $"Quiz completed. Score: {score}/{quiz.Count}"
                );

                Close();
                return;
            }

            LoadQuestion();
        }
    }
}