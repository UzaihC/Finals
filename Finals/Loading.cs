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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (prog.Value < 100)
            {
                prog.Value += 1;
                Lolo.Text = prog.Value.ToString() + "%";

            }
            else
            {
                timer1.Stop();
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void prog_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Lolo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
