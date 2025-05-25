using System;
using System.Data;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

namespace Finals

{
    class Classconnection
    {
        private string server = "localhost";
        private string database = "loglog";
        private string username = "root";
        private string password = "";
        private string connString;

        public Classconnection()
        {
            connString = $"Server={server};Database={database};User ID ={username};Password={password};";
        }

        public string GetConnectionString()
        {
            return connString;
        }

        public void InsertData(string Username, string Password)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query ="INSERT INTO registeredusers(Username, Password) VALUES(@Username, @Password)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", Username);
                        cmd.Parameters.AddWithValue("@Password", Password);
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
        public bool UpdatePassword(string Username, string newPassword)
        {
            using (MySqlConnection conn = new MySqlConnection(GetConnectionString()))
            {
                conn.Open();
                string query = "UPDATE registeredusers SET Password = @password WHERE Username = @Username";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Password", newPassword);
                    cmd.Parameters.AddWithValue("@Username", Username);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }


    }
}

