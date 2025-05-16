namespace Finals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string EmailL = LogEmail.Text;

            string PassL = LogPass.Text;
            Classconnection conn = new Classconnection();
            if (conn.ValidateLogin(EmailL, PassL))
            {
                MessageBox.Show("Login Succesfully!!");
            }
            else
            {
                MessageBox.Show("Invalid Username!!");
            }

            bool isValidUser = true;

            if (isValidUser)
            {
                Form4 optionsForm = new Form4();
                optionsForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 Register = new Form2();
            Register.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void LogEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Password Pass = new Password();
            Pass.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
