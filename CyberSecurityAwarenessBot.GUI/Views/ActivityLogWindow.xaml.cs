using CyberSecurityAwarenessBot.GUI.Services;
using CyberSecurityAwarenessBot.GUI.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CyberSecurityAwarenessBot.GUI.Views
{
    public partial class ActivityLogWindow : Window
    {
        public ActivityLogWindow()
        {
            InitializeComponent();

            LogListBox.ItemsSource =
                ActivityLogService.GetRecentLogs();
        }
    }
}