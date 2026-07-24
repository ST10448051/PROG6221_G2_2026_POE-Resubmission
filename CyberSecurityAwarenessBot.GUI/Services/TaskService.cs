using CyberSecurityAwarenessBot.GUI.Models;
using MySql.Data.MySqlClient;

namespace CyberSecurityAwarenessBot.GUI.Services
{
    public class TaskService
    {
        private readonly DatabaseService database = new();
        private List<TaskItem> tasks;

        public void AddTask(TaskItem task)
        {
            using var connection = database.GetConnection();

            connection.Open();

            string sql = @"INSERT INTO Tasks
                   (Title, Description, ReminderDate, Completed)
                   VALUES
                   (@Title,@Description,@ReminderDate,@Completed)";

            using var command = new MySqlCommand(sql, connection);

            command.Parameters.AddWithValue("@Title", task.Title);
            command.Parameters.AddWithValue("@Description", task.Description);
            command.Parameters.AddWithValue("@ReminderDate", task.ReminderDate);
            command.Parameters.AddWithValue("@Completed", task.Completed);

            command.ExecuteNonQuery();
        }

        public List<TaskItem> GetTasks()
        {
            return tasks;
        }

        public void CompleteTask(int id)
        {
            TaskItem? task = tasks.FirstOrDefault(t => t.Id == id);

            if (task != null)
            {
                task.Completed = true;
            }
        }
    }
}