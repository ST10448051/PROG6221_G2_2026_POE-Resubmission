using System;
using System.Collections.Generic;

namespace CyberSecurityAwarenessBot.GUI.Services
{
    public static class ActivityLogService
    {
        private static readonly List<string> activityLog = new();

        public static void AddLog(string action)
        {
            activityLog.Add(
                $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {action}"
            );
        }

        public static List<string> GetRecentLogs(int count = 10)
        {
            return activityLog
                .TakeLast(count)
                .ToList();
        }
    }
}