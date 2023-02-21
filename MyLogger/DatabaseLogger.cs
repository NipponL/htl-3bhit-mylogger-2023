using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyLogger
{
    internal class DatabaseLogger : ILogger
    {
        public readonly string _connectionString;
        public DatabaseLogger(string connectionString)
        {
            _connectionString = connectionString;
            using (var connection = new SqliteConnection(_connectionString))
            {
             
                connection.Open();
               
                var command = connection.CreateCommand();

                command.CommandText = "CREATE TABLE IF NOT EXISTS log (Id INTEGER PRIMARY KEY AUTOINCREMENT, Date TIMESTAMP NOT NULL, Level VARCHAR(20) NOT NULL, Message TEXT NOT NULL)";
               command.ExecuteNonQuery();
             
                connection.Close();
            }
        }
        public void Log(string message, LogLevel level)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                
                    command.CommandText = "INSERT INTO log (Date, Level, Message) VALUES (@date, @level, @message)";
                    command.Parameters.AddWithValue("date", DateTime.Now);
                    command.Parameters.AddWithValue("level", level.ToString());
                    command.Parameters.AddWithValue("message", message);
                    command.ExecuteNonQuery();
                
                connection.Close();
            }
        }
    }
}
