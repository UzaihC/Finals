namespace Finals
{
    partial class Profile
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            prof = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1 = new Panel();
            LabelUsername = new Guna.UI2.WinForms.Guna2HtmlLabel();
            button1 = new Button();
            Greetings = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panel2 = new Panel();
            DATA2 = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DATA2).BeginInit();
            SuspendLayout();
            // 
            // prof
            // 
            prof.BorderRadius = 30;
            prof.TargetControl = this;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 0, 0);
            panel1.Controls.Add(LabelUsername);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(Greetings);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(666, 100);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // LabelUsername
            // 
            LabelUsername.BackColor = Color.Transparent;
            LabelUsername.Font = new Font("OCR A Extended", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelUsername.Location = new Point(25, 45);
            LabelUsername.Name = "LabelUsername";
            LabelUsername.Size = new Size(143, 27);
            LabelUsername.TabIndex = 2;
            LabelUsername.Text = "Donor Name";
            LabelUsername.Click += donorName_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(581, 17);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Greetings
            // 
            Greetings.BackColor = Color.Transparent;
            Greetings.Font = new Font("OCR A Extended", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Greetings.Location = new Point(25, 12);
            Greetings.Name = "Greetings";
            Greetings.Size = new Size(101, 27);
            Greetings.TabIndex = 0;
            Greetings.Text = "Welcome";
            Greetings.Click += guna2HtmlLabel1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 0, 0);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(103, 313);
            panel2.TabIndex = 1;
            // 
            // DATA2
            // 
            dataGridViewCellStyle7.BackColor = Color.White;
            DATA2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            DATA2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            DATA2.ColumnHeadersHeight = 17;
            DATA2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            DATA2.DefaultCellStyle = dataGridViewCellStyle9;
            DATA2.GridColor = Color.FromArgb(231, 229, 255);
            DATA2.Location = new Point(127, 117);
            DATA2.Name = "DATA2";
            DATA2.RowHeadersVisible = false;
            DATA2.Size = new Size(527, 284);
            DATA2.TabIndex = 2;
            DATA2.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DATA2.ThemeStyle.AlternatingRowsStyle.Font = null;
            DATA2.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DATA2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DATA2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DATA2.ThemeStyle.BackColor = Color.White;
            DATA2.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DATA2.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DATA2.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DATA2.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            DATA2.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DATA2.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DATA2.ThemeStyle.HeaderStyle.Height = 17;
            DATA2.ThemeStyle.ReadOnly = false;
            DATA2.ThemeStyle.RowsStyle.BackColor = Color.White;
            DATA2.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DATA2.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            DATA2.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DATA2.ThemeStyle.RowsStyle.Height = 25;
            DATA2.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DATA2.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DATA2.CellContentClick += guna2DataGridView1_CellContentClick;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 413);
            Controls.Add(DATA2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Profile";
            Text = "Profile";
            Load += Profile_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DATA2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse prof;
        private Panel panel2;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView DATA2;
        private Button button1;
        private Guna.UI2.WinForms.Guna2HtmlLabel Greetings;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelUsername;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}