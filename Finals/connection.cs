using System;
using MySql.Data.MySqlClient;

namespace Finals

{
        class Classconnection
        {
            private string server = "localhost";
            private string database = "login";
            private string username = "root";
            private string password = "";
            private string connString;

            public Classconnection()
            {
                connString = $"Server={server};Database={database};User ID ={username};Password={password};";
            }

            public void InsertData(string Username, string Password)
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        string query = "INSERT INTO registeredusers (Username, Password) VALUES (@username, @password)";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@username", Username);
                            cmd.Parameters.AddWithValue("@password", Password);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            MessageBox.Show(rowsAffected > 0 ? "Data inserted successfully!!!" : "Failed to insert data.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }

                }

            }
        public bool ValidateLogin(string Username, string Password)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM registeredusers WHERE Username = @Username AND Password = @Password";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", Username);
                        cmd.Parameters.AddWithValue("@Password", Password);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
        public bool UserExists(string Username)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM registeredusers WHERE Username = @Username";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", Username);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

    }
    
}

