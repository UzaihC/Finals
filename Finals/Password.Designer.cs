namespace Finals
{
    partial class Password
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
            label3 = new Label();
            txtConfirmPassword = new TextBox();
            label2 = new Label();
            txtNewPassword = new TextBox();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtConfirmPassword);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNewPassword);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(17, 28);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(610, 755);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.OrangeRed;
            button1.Font = new Font("OCR A Extended", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(38, 541);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(187, 56);
            button1.TabIndex = 10;
            button1.Text = "CONTINUE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("OCR A Extended", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(39, 267);
            label3.Name = "label3";
            label3.Size = new Size(188, 17);
            label3.TabIndex = 7;
            label3.Text = "Confirm New Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(38, 293);
            txtConfirmPassword.Margin = new Padding(3, 4, 3, 4);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(521, 27);
            txtConfirmPassword.TabIndex = 6;
            txtConfirmPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.TextChanged += txtConfirmPassword_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("OCR A Extended", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 161);
            label2.Name = "label2";
            label2.Size = new Size(116, 17);
            label2.TabIndex = 5;
            label2.Text = "New Password";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(38, 188);
            txtNewPassword.Margin = new Padding(3, 4, 3, 4);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(521, 27);
            txtNewPassword.TabIndex = 4;
            txtNewPassword.UseSystemPasswordChar = true;
            txtNewPassword.TextChanged += txtNewPassword_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Desktop;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(610, 95);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("OCR A Extended", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(177, 39);
            label1.Name = "label1";
            label1.Size = new Size(299, 32);
            label1.TabIndex = 0;
            label1.Text = "FORGOT PASSWORD";
            // 
            // Password
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pngtree_youth_geometric_gradient_architectural_silhouette_inspirational_picture_image_976352;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(647, 801);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Password";
            Text = "Password";
            Load += Password_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label3;
        private TextBox txtConfirmPassword;
        private Label label2;
        private TextBox txtNewPassword;
        private Button button1;
    }
}