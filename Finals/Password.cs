using System;
using System.Windows.Forms;

namespace Finals
{
    public partial class Password : Form
    {

        private string username;

        public Password(string user)
        {
            InitializeComponent();
            username = user;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Try again.");
                return;
            }

            username = username.Trim();

            Classconnection conn = new Classconnection();
            bool success = conn.UpdatePassword(username, newPassword);

            if (success)
            {
                MessageBox.Show($"Password updated successfully for user: {username}!");
                this.Hide();
                Form1 loginform = new Form1();
                loginform.Show();
            }
            else
            {
                MessageBox.Show($"Failed to update password for: {username}. Double check if user exists.");
            }
        }


        private void Password_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            txtNewPassword.PasswordChar = '•';
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            txtConfirmPassword.PasswordChar = '•';
        }
    }
}
