using System;

namespace Finals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string Username = LogUser.Text;
            string Password = LogPass.Text;
            Classconnection conn = new Classconnection();
            if (conn.ValidateLogin(Username, Password))
            {
                Session.currentUsername = Username;
                MessageBox.Show("Login Succesfully!!");
                this.Hide();
                Form4 optionsform = new Form4();
                optionsform.Show();

            }
            else
            {
                MessageBox.Show("Invalid Username!!");
            }
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 Register = new Form2();
            Register.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void LogEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OTP otpform = new OTP();
            otpform.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LogPass.PasswordChar = '•';
        }

        private void LogPass_TextChanged(object sender, EventArgs e)
        {

        }
        private void showPass_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LogEmail_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
