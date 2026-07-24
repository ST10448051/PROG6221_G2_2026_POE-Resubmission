using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using CyberSecurityAwarenessBot.GUI.Models;
using CyberSecurityAwarenessBot.GUI.Services;

namespace CyberSecurityAwarenessBot.GUI
{
    public partial class MainWindow : Window
    {
        private readonly ChatService chatService = new();
        private readonly TaskService taskService = new();

        public MainWindow()
        {
            InitializeComponent();

            SendButton.Click += SendButton_Click;
            MessageBox.KeyDown += MessageBox_KeyDown;

            AddBotMessage("Hello! 👋");
            AddBotMessage("Welcome to the Cybersecurity Awareness Chatbot.");
            AddBotMessage("Ask me about passwords, phishing, scams or privacy.");
        }

        private void MessageBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                SendMessage();
            }
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            SendMessage();
        }

        private void SendMessage()
        {
            if (string.IsNullOrWhiteSpace(MessageBox.Text))
                return;

            string userMessage = MessageBox.Text;

            AddUserMessage(userMessage);

            Message response = chatService.GetResponse(userMessage);

            AddBotMessage(response.Text);

            MessageBox.Clear();
            MessageBox.Focus();
        }

        private void AddUserMessage(string message)
        {
            Border border = new Border
            {
                Background = Brushes.DodgerBlue,
                CornerRadius = new CornerRadius(12),
                Padding = new Thickness(10),
                Margin = new Thickness(150, 5, 0, 5),
                HorizontalAlignment = HorizontalAlignment.Right
            };

            border.Child = new TextBlock
            {
                Text = message,
                Foreground = Brushes.White,
                FontSize = 16,
                TextWrapping = TextWrapping.Wrap
            };

            ChatPanel.Children.Add(border);
        }

        private void AddBotMessage(string message)
        {
            Border border = new Border
            {
                Background = Brushes.DimGray,
                CornerRadius = new CornerRadius(12),
                Padding = new Thickness(10),
                Margin = new Thickness(0, 5, 150, 5),
                HorizontalAlignment = HorizontalAlignment.Left
            };

            border.Child = new TextBlock
            {
                Text = message,
                Foreground = Brushes.White,
                FontSize = 16,
                TextWrapping = TextWrapping.Wrap
            };

            ChatPanel.Children.Add(border);
        }
    }
}