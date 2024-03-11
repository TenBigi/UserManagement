using System.Data.SQLite;
using UserManagemet.Data;
using System.IO;

namespace UserManagemet.Data
{
    internal class DbHelper
    {
        private static string connectionString = @"Data Source=.\users.db;Version=3;";

        public static void DbInit()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                string createTable = @"
                    CREATE TABLE IF NOT EXISTS users (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    login TEXT NOT NULL,
                    passwdAes TEXT NOT NULL
                    );    
                ";

                SQLiteCommand cmd = new SQLiteCommand(createTable, conn);
                
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public static void RegisterUser(string username, string password)
        {
            string query = "INSERT INTO users (login, passwdAes) VALUES (@username, @password)";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static User IsUserInDatabase(string username, string passwd)
        {
            string query = "SELECT COUNT(*) FROM users WHERE login = @username";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("username", username);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        return new User
                        {
                            Name = username,
                            Password = passwd
                        };
                    }

                    return null;
                }
            }
        }
    }
}
