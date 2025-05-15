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
            panel1 = new Panel();
            button1 = new Button();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            label3 = new Label();
            TextSearch = new TextBox();
            DATA = new DataGridView();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DATA).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(guna2HtmlLabel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(812, 67);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("OCR A Extended", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 22);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Esc";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("OCR A Extended", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(239, 12);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(345, 37);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "DONATION DASHBOARD";
            guna2HtmlLabel1.Click += guna2HtmlLabel1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 92);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 5;
            label3.Text = "Search Donor";
            // 
            // TextSearch
            // 
            TextSearch.Location = new Point(102, 89);
            TextSearch.Name = "TextSearch";
            TextSearch.Size = new Size(94, 23);
            TextSearch.TabIndex = 6;
            TextSearch.TextChanged += textBox1_TextChanged;
            // 
            // DATA
            // 
            DATA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DATA.Location = new Point(12, 118);
            DATA.Name = "DATA";
            DATA.Size = new Size(444, 452);
            DATA.TabIndex = 7;
            DATA.CellContentClick += DataGridViewDonors_CellContentClick;
            // 
            // button2
            // 
            button2.Font = new Font("OCR A Extended", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(686, 580);
            button2.Name = "button2";
            button2.Size = new Size(115, 49);
            button2.TabIndex = 8;
            button2.Text = "EXIT";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 756);
            Controls.Add(button2);
            Controls.Add(DATA);
            Controls.Add(TextSearch);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DATA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Label label3;
        private TextBox TextSearch;
        private DataGridView DATA;
        private Button button1;
        private Button button2;
    }
}