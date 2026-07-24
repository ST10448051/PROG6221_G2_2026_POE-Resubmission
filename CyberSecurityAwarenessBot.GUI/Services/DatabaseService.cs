using MySql.Data.MySqlClient;

namespace CyberSecurityAwarenessBot.GUI.Services
{
    public class DatabaseService
    {
        private readonly string connectionString =
            "server=localhost;database=CyberSecurityBot;uid=root;pwd=SoCS2026!;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}