using Mysqlx.Expr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Finals
{
    public partial class OTP : Form
    {

        public OTP()
        {
            InitializeComponent();
        }
        private static Dictionary<string, (string otp, DateTime expiry)> otpStorage = new Dictionary<string, (string otp, DateTime expiry)>();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string email = emailbox.Text;
            string userOTP = otpbox.Text;
            string? otp = otpStorage.ContainsKey(email) ? otpStorage[email].otp : null;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(userOTP))
            {
                MessageBox.Show("Please enter both email and OTP.");
                return;
            }
            else if (otp == null)
            {
                MessageBox.Show("No OTP generated for this email.");
                return;
            }
            else if (otpStorage[email].expiry < DateTime.Now)
            {
                MessageBox.Show("OTP has expired.");
                return;
            }
            else if (userOTP == otp)
            {
                MessageBox.Show("OTP verified successfully.");
                this.Hide();
                Password Password = new Password();
                Password.Show();
            }
            else
            {
                MessageBox.Show("Invalid OTP. Please try again.");
            }



        }

        private void send_Click(object sender, EventArgs e)
        {
            string email = emailbox.Text;
            string otp = Finals.OTPs.GenerateOTP();
            DateTime expiry = DateTime.Now.AddMinutes(5);


            otpStorage[email] = (otp, expiry);

            Email send = new Email();
            send.SendEmail(email, otp);
        }

        private void otpbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
