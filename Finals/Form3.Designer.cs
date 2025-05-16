namespace Finals
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            DATA = new DataGridView();
            TextSearch = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DATA).BeginInit();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("OCR A Extended", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(261, 12);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(323, 31);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "LEVELING CORPORATION";
            guna2HtmlLabel1.Click += guna2HtmlLabel1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(0, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(171, 420);
            panel1.TabIndex = 18;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkKhaki;
            button4.Location = new Point(43, 33);
            button4.Name = "button4";
            button4.Size = new Size(75, 28);
            button4.TabIndex = 2;
            button4.Text = "PROFILE";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkKhaki;
            button3.Location = new Point(43, 241);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 1;
            button3.Text = "ABOUT";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkKhaki;
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(43, 270);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 0;
            button2.Text = "LOGOUT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(812, 77);
            panel2.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("OCR A Extended", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Image = Properties.Resources.dean1;
            label2.Location = new Point(343, 38);
            label2.Name = "label2";
            label2.Size = new Size(188, 17);
            label2.TabIndex = 2;
            label2.Text = "DONATION DASHBOARD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("OCR A Extended", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Image = Properties.Resources.dean1;
            label1.Location = new Point(265, 9);
            label1.Name = "label1";
            label1.Size = new Size(333, 29);
            label1.TabIndex = 1;
            label1.Text = "LEVELING CORPORATION";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.dean1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(812, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.InactiveCaption;
            panel3.Controls.Add(DATA);
            panel3.Controls.Add(TextSearch);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(199, 105);
            panel3.Name = "panel3";
            panel3.Size = new Size(584, 376);
            panel3.TabIndex = 20;
            // 
            // DATA
            // 
            DATA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DATA.Location = new Point(92, 67);
            DATA.Name = "DATA";
            DATA.Size = new Size(422, 243);
            DATA.TabIndex = 10;
            DATA.CellContentClick += DATA_CellContentClick;
            // 
            // TextSearch
            // 
            TextSearch.Location = new Point(173, 37);
            TextSearch.Name = "TextSearch";
            TextSearch.Size = new Size(94, 23);
            TextSearch.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 40);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 8;
            label3.Text = "Search Donor";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Control;
            ClientSize = new Size(812, 493);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load_1;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DATA).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button4;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private DataGridView DATA;
        private TextBox TextSearch;
        private Label label3;
        private Label label1;
        private Label label2;
    }
}