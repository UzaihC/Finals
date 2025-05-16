using MySql.Data.MySqlClient;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string donor = textBox1.Text;
            string amount = textBox2.Text;
            string recipient = textBox3.Text;
            DateTime donationDate = DateTime.Now;

            string connString = "server=localhost;user=root;database=loglog;";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string query = "INSERT INTO donations (donor, amount, recipient, donation_date) VALUES (@donor, @amount, @recipient, @donationDate)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@donor", donor);
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.Parameters.AddWithValue("@recipient", recipient);
                    cmd.Parameters.AddWithValue("@donationDate", donationDate);
                    cmd.ExecuteNonQuery();
                }
            }



            Form3 donationForm = new Form3();
            donationForm.Show();
            this.Hide();
            MessageBox.Show("THANK YOU FOR DONATING!!!");


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 donationForm = new Form4();
            donationForm.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

    }
}
