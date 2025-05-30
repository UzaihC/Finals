﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Finals
{
    public partial class Form5 : Form
    {
        private string currentUsername;
        public Form5(string currentUsername)
        {
            InitializeComponent();
            this.currentUsername = currentUsername;
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            txtEmail.Text = currentUsername;
            txtEmail.ReadOnly = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string donor = currentUsername;
            string amount = txtAmount.Text;
            string recipient = txtRecipient.Text;
            DateTime donationDate = DateTime.Now;
            Email.SendReceipt(email, currentUsername, amount, recipient);

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



            MessageBox.Show("THANK YOU FOR DONATING!!!");
            Form3 donationForm = new Form3(currentUsername);
            donationForm.Show();
            this.Hide();



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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void receiptBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
