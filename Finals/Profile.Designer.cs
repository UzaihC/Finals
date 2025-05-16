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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            prof = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1 = new Panel();
            donorName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            button1 = new Button();
            Greetings = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panel2 = new Panel();
            DATA2 = new Guna.UI2.WinForms.Guna2DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
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
            panel1.Controls.Add(donorName);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(Greetings);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(528, 100);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // donorName
            // 
            donorName.BackColor = Color.Transparent;
            donorName.Font = new Font("OCR A Extended", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            donorName.Location = new Point(158, 36);
            donorName.Name = "donorName";
            donorName.Size = new Size(143, 27);
            donorName.TabIndex = 2;
            donorName.Text = "Donor Name";
            donorName.Click += donorName_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(441, 36);
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
            Greetings.Location = new Point(32, 36);
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
            panel2.Size = new Size(103, 223);
            panel2.TabIndex = 1;
            // 
            // DATA2
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            DATA2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DATA2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DATA2.ColumnHeadersHeight = 17;
            DATA2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DATA2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DATA2.DefaultCellStyle = dataGridViewCellStyle3;
            DATA2.GridColor = Color.FromArgb(231, 229, 255);
            DATA2.Location = new Point(109, 106);
            DATA2.Name = "DATA2";
            DATA2.RowHeadersVisible = false;
            DATA2.Size = new Size(407, 205);
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
            // Column1
            // 
            Column1.HeaderText = "Recipient";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Amount";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Date";
            Column3.Name = "Column3";
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 323);
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
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button button1;
        private Guna.UI2.WinForms.Guna2HtmlLabel Greetings;
        private Guna.UI2.WinForms.Guna2HtmlLabel donorName;
    }
}