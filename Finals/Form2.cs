using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finals
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
            Classconnection conn = new Classconnection();
            string Email = EmailT.Text;

            string Password = PassW.Text;
            if (conn.UserExists(Email))
            {
                MessageBox.Show("Email Already Exist");
            }
            else
            {
                conn.InsertData(Email, Password);
            }

        }

        private void PassW_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            PassW.PasswordChar = '•';
        }

        private void EmailT_TextChanged(object sender, EventArgs e)
        {

        }

        private void showPass2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LogEmail2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
