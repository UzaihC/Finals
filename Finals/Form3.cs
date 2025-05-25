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


    public partial class Form3 : Form
    {
        private string currentUsername;
        public Form3(string username)
        {
            InitializeComponent();
            currentUsername = username;
        }
        Classconnection connect = new Classconnection();
        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DataGridViewDonors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 donationForm = new Form4();
            donationForm.Show();
            this.Hide();
        }
        private void Form3_Load_1(object sender, EventArgs e)
        {
            LoadDonorData();
        }
        public void LoadDonorData()
        {

            using (MySqlConnection conn = new MySqlConnection(connect.GetConnectionString()))
            {
                conn.Open();
                string query = "SELECT donor, amount, recipient, donation_date FROM donations";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DATA.DataSource = table;
            }
            SetupAutoComplete();
        }

        private void SetupAutoComplete()
        {
            AutoCompleteStringCollection autoCompleteData = new AutoCompleteStringCollection();

            using (MySqlConnection conn = new MySqlConnection(connect.GetConnectionString()))
            {
                conn.Open();
                string query = "SELECT DISTINCT donor FROM donations UNION SELECT DISTINCT recipient FROM donations";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            autoCompleteData.Add(reader.GetString(0));
                        }
                    }
                }
            }

            textBoxSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxSearch.AutoCompleteCustomSource = autoCompleteData;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
        }


        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.Trim();

            using (MySqlConnection conn = new MySqlConnection(connect.GetConnectionString()))
            {
                conn.Open();
                string query = @"SELECT donor, amount, recipient, donation_date FROM donations WHERE donor LIKE @search OR recipient LIKE @search";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    DATA.DataSource = dt;
                }
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form4 donationForm = new Form4();
            donationForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Profile profile1 = new Profile(currentUsername);
            profile1.Show();
            this.Hide();
        }

        private void DATA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            about about1 = new about();
            about1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Form4 optionform = new Form4();
            optionform.Show();
            this.Hide();

        }

        private void DATA_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
