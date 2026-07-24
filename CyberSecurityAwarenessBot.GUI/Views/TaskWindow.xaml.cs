using System.Windows;
using CyberSecurityAwarenessBot.GUI.Models;
using CyberSecurityAwarenessBot.GUI.Services;

namespace CyberSecurityAwarenessBot.GUI.Views
{
    public partial class TaskWindow : Window
    {
        private readonly TaskService taskService = new();

        public TaskWindow()
        {
            InitializeComponent();

            AddTaskButton.Click += AddTaskButton_Click;
            DeleteTaskButton.Click += DeleteTaskButton_Click;

            RefreshGrid();
        }

        private void AddTaskButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TitleBox.Text))
            {
                MessageBox.Show("Please enter a task title.");
                return;
            }

            taskService.AddTask(new TaskItem
            {
                Title = TitleBox.Text,
                Description = DescriptionBox.Text,
                ReminderDate = DateTime.Now.AddDays(1),
                Completed = false
            });

            RefreshGrid();

            TitleBox.Clear();
            DescriptionBox.Clear();
        }

        private void DeleteTaskButton_Click(object sender, RoutedEventArgs e)
        {
            if (TaskGrid.SelectedItem == null)
            {
                MessageBox.Show("Please select a task.");
                return;
            }

            TaskItem task = (TaskItem)TaskGrid.SelectedItem;

            taskService.DeleteTask(task.Id);

            RefreshGrid();
        }

        private void RefreshGrid()
        {
            TaskGrid.ItemsSource = null;
            TaskGrid.ItemsSource = taskService.GetTasks();
        }

    }
}