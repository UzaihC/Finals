namespace Finals
{
    partial class OTP
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            send = new Guna.UI2.WinForms.Guna2Button();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            otpbox = new TextBox();
            emailbox = new TextBox();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(send);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(otpbox);
            panel1.Controls.Add(emailbox);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(19, 24);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(635, 731);
            panel1.TabIndex = 0;
            // 
            // send
            // 
            send.CustomizableEdges = customizableEdges1;
            send.DisabledState.BorderColor = Color.DarkGray;
            send.DisabledState.CustomBorderColor = Color.DarkGray;
            send.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            send.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            send.Font = new Font("Segoe UI", 9F);
            send.ForeColor = Color.White;
            send.Location = new Point(250, 315);
            send.Margin = new Padding(3, 4, 3, 4);
            send.Name = "send";
            send.ShadowDecoration.CustomizableEdges = customizableEdges2;
            send.Size = new Size(153, 43);
            send.TabIndex = 6;
            send.Text = "Send Otp";
            send.Click += send_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.OrangeRed;
            button1.Font = new Font("OCR A Extended", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(37, 401);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(187, 56);
            button1.TabIndex = 5;
            button1.Text = "CONTINUE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 297);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 4;
            label3.Text = "OTP Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 180);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 3;
            label2.Text = "Email";
            // 
            // otpbox
            // 
            otpbox.Location = new Point(40, 321);
            otpbox.Margin = new Padding(3, 4, 3, 4);
            otpbox.Name = "otpbox";
            otpbox.Size = new Size(178, 27);
            otpbox.TabIndex = 2;
            // 
            // emailbox
            // 
            emailbox.Location = new Point(40, 207);
            emailbox.Margin = new Padding(3, 4, 3, 4);
            emailbox.Name = "emailbox";
            emailbox.Size = new Size(521, 27);
            emailbox.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(635, 95);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("OCR A Extended", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(208, 29);
            label1.Name = "label1";
            label1.Size = new Size(242, 32);
            label1.TabIndex = 0;
            label1.Text = "CONFIRMATION";
            // 
            // OTP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pngtree_youth_geometric_gradient_architectural_silhouette_inspirational_picture_image_976352;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(682, 780);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "OTP";
            Text = "OTP";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private TextBox otpbox;
        private TextBox emailbox;
        private Panel panel2;
        private Label label1;
        private Button button1;
        private Guna.UI2.WinForms.Guna2Button send;
    }
}