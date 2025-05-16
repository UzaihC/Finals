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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Finals
{
    public partial class Profile : Form
    {
        private string DonorName;
        Classconnection connect = new Classconnection();
        public Profile(string donorName)
        {
            InitializeComponent();
           
            this.DonorName = donorName;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            Greetings.Text = $"Welcome";
            SearchDonor("dean");
            LoadDonations();
        }

        private void LoadDonations()
        {
            string connString = "server=localhost;user=root;database=loglog;SslMode=None;";
            string query = "SELECT donor FROM donations WHERE donor = @donor";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@donor", DonorName);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    DATA2.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading donation history: " + ex.Message);
                }
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
                        
                        cmd.Parameters.AddWithValue("@donor", donor);

                        using(MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                donorName.Text = reader["donor"].ToString();
                                
                            }
                            else
                            {
                                MessageBox.Show("No donor found with that name.");
                            }
                        }


                    }
;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            this.Show();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void donorName_Click(object sender, EventArgs e)
        {

        }
    }
}
