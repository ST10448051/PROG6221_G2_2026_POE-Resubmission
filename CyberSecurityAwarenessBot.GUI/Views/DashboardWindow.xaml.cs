using System.Windows;

namespace CyberSecurityAwarenessBot.GUI.Views
{
    public partial class DashboardWindow : Window
    {
        public DashboardWindow()
        {
            InitializeComponent();

            ChatButton.Click += ChatButton_Click;
            TaskButton.Click += TaskButton_Click;
            QuizButton.Click += QuizButton_Click;
            LogButton.Click += LogButton_Click;
        }

        private void ChatButton_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().ShowDialog();
        }

        private void TaskButton_Click(object sender, RoutedEventArgs e)
        {
            new TaskWindow().ShowDialog();
        }

        private void QuizButton_Click(object sender, RoutedEventArgs e)
        {
            new QuizWindow().ShowDialog();
        }

        private void LogButton_Click(object sender, RoutedEventArgs e)
        {
            new ActivityLogWindow().ShowDialog();
        }
    }
}