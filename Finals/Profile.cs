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
        private string CurrentUsername;
        Classconnection connect = new Classconnection();
        public Profile(string username)
        {
            InitializeComponent();
            CurrentUsername = username;

        }
        private void Profile_Load(object sender, EventArgs e)
        {
            LabelUsername.Text = CurrentUsername; // Display username
            LoadUsersDonations();
        }

        private void LoadUsersDonations()
        {
            using (MySqlConnection conn = new MySqlConnection(connect.GetConnectionString()))
            {
                conn.Open();
                string query = "SELECT donor, amount, recipient, donation_date FROM donations WHERE donor = @donor";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@donor", CurrentUsername);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DATA2.DataSource = table;
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
                                LabelUsername.Text = reader["donor"].ToString();
                                
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
            Form3 form3 = new Form3(Session.currentUsername);
            form3.Show();
            this.Hide();
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
