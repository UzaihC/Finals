namespace Finals
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            LogEmail = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            panel2 = new Panel();
            linkLabel1 = new LinkLabel();
            checkBox1 = new CheckBox();
            linkLabel2 = new LinkLabel();
            label4 = new Label();
            LogPass = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(854, 43);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 14);
            label1.Name = "label1";
            label1.Size = new Size(81, 14);
            label1.TabIndex = 3;
            label1.Text = "Leveling Corp.";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(819, 0);
            button1.Name = "button1";
            button1.Size = new Size(35, 43);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.pngtree_youth_geometric_gradient_architectural_silhouette_inspirational_picture_image_976352;
            button2.Location = new Point(91, 295);
            button2.Name = "button2";
            button2.Size = new Size(226, 47);
            button2.TabIndex = 1;
            button2.Text = "LOG IN";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // LogEmail
            // 
            LogEmail.CustomizableEdges = customizableEdges1;
            LogEmail.DefaultText = "";
            LogEmail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            LogEmail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            LogEmail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            LogEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            LogEmail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            LogEmail.Font = new Font("Segoe UI", 9F);
            LogEmail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            LogEmail.Location = new Point(39, 113);
            LogEmail.Name = "LogEmail";
            LogEmail.PlaceholderText = "";
            LogEmail.SelectedText = "";
            LogEmail.ShadowDecoration.CustomizableEdges = customizableEdges2;
            LogEmail.Size = new Size(329, 29);
            LogEmail.TabIndex = 2;
            LogEmail.TextChanged += LogEmail_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 128, 0);
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(174, 26);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 3;
            label2.Text = "LOGIN";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonShadow;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(linkLabel2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(LogPass);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(LogEmail);
            panel2.Location = new Point(12, 105);
            panel2.Name = "panel2";
            panel2.Size = new Size(406, 477);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Transparent;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.LinkColor = Color.Red;
            linkLabel1.Location = new Point(273, 209);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(95, 15);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Location = new Point(39, 209);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = SystemColors.Control;
            linkLabel2.LinkColor = SystemColors.ActiveCaptionText;
            linkLabel2.Location = new Point(144, 360);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(116, 15);
            linkLabel2.TabIndex = 9;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Create New Account";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.InactiveBorder;
            label4.Location = new Point(39, 156);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 7;
            label4.Text = "Password";
            // 
            // LogPass
            // 
            LogPass.CustomizableEdges = customizableEdges3;
            LogPass.DefaultText = "";
            LogPass.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            LogPass.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            LogPass.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            LogPass.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            LogPass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            LogPass.Font = new Font("Segoe UI", 9F);
            LogPass.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            LogPass.Location = new Point(39, 174);
            LogPass.Name = "LogPass";
            LogPass.PlaceholderText = "";
            LogPass.SelectedText = "";
            LogPass.ShadowDecoration.CustomizableEdges = customizableEdges4;
            LogPass.Size = new Size(329, 29);
            LogPass.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Location = new Point(39, 95);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("OCR A Extended", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(441, 313);
            label5.Name = "label5";
            label5.Size = new Size(387, 25);
            label5.TabIndex = 5;
            label5.Text = "WELCOME TO LEVELING CORP.\r\n";
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(854, 656);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            TransparencyKey = Color.DimGray;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Button button2;
        private Guna.UI2.WinForms.Guna2TextBox LogEmail;
        private Label label2;
        private Panel panel2;
        private Label label4;
        private Guna.UI2.WinForms.Guna2TextBox LogPass;
        private Label label3;
        private LinkLabel linkLabel2;
        private CheckBox checkBox1;
        private Label label5;
        private LinkLabel linkLabel1;
    }
}
