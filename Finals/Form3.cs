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
        public Form3()
        {
            InitializeComponent();
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


        }
        private void SearchDonor(string donor)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connect.GetConnectionString()))
                {
                    conn.Open();
                    string query = "SELECT * FROM donations WHERE donor = @donor";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        MessageBox.Show("Connected");
                        cmd.Parameters.AddWithValue("@donor", donor);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        DATA.DataSource = dt;
                    }
;

                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //SearchDonor(TextSearch.Text);
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
            this.Hide();
            Profile profile1 = new Profile("donorName");

            profile1.Show();
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

    }
}
