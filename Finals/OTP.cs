using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Finals
{
    public partial class OTP : Form
    {
        public OTP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = emailbox.Text;
            string userOTP = otpbox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(userOTP))
            {
                MessageBox.Show("Please enter both email and OTP.");
                return;
            }

            var otpRecord = OTPs.GetStoredOtp(username);

            if (otpRecord == null)
            {
                MessageBox.Show("No OTP generated for this email.");
                return;
            }

            string storedOtp = otpRecord.Value.otp;
            DateTime expiry = otpRecord.Value.expiry;

            if (expiry < DateTime.Now)
            {
                MessageBox.Show("OTP has expired.");
                return;
            }

            if (userOTP == storedOtp)
            {
                MessageBox.Show("OTP verified successfully.");
                this.Hide();
                Password passwordForm = new Password(username);
                passwordForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid OTP. Please try again.");
            }
        }

        private void send_Click(object sender, EventArgs e)
        {
            string email = emailbox.Text;
            string otp = OTPs.GenerateOTP();
            DateTime expiry = DateTime.Now.AddMinutes(5);

            OTPs.StoreOtp(email, otp, expiry);

            Email send = new Email();
            send.SendEmail(email, otp);
        }
    }
}
