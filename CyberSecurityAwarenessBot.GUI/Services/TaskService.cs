using CyberSecurityAwarenessBot.GUI.Models;
using MySql.Data.MySqlClient;

namespace CyberSecurityAwarenessBot.GUI.Services
{
    public class TaskService
    {
        private readonly DatabaseService database = new();

        public void AddTask(TaskItem task)
        {
            using var connection = database.GetConnection();
            connection.Open();

            string sql = @"INSERT INTO Tasks
                           (Title, Description, ReminderDate, Completed)
                           VALUES
                           (@Title, @Description, @ReminderDate, @Completed)";

            using var command = new MySqlCommand(sql, connection);

            command.Parameters.AddWithValue("@Title", task.Title);
            command.Parameters.AddWithValue("@Description", task.Description);
            command.Parameters.AddWithValue("@ReminderDate", task.ReminderDate);
            command.Parameters.AddWithValue("@Completed", task.Completed);

            command.ExecuteNonQuery();
        }

        public List<TaskItem> GetTasks()
        {
            List<TaskItem> tasks = new();

            using var connection = database.GetConnection();
            connection.Open();

            string sql = "SELECT * FROM Tasks";

            using var command = new MySqlCommand(sql, connection);
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                tasks.Add(new TaskItem
                {
                    Id = reader.GetInt32("Id"),
                    Title = reader.GetString("Title"),
                    Description = reader.GetString("Description"),
                    ReminderDate = reader.GetDateTime("ReminderDate"),
                    Completed = reader.GetBoolean("Completed")
                });
            }

            return tasks;
        }

        public void CompleteTask(int id)
        {
            using var connection = database.GetConnection();
            connection.Open();

            string sql = "UPDATE Tasks SET Completed = 1 WHERE Id = @Id";

            using var command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Id", id);

            command.ExecuteNonQuery();
        }

        internal void DeleteTask(int id)
        {
            throw new NotImplementedException();
        }
    }
}