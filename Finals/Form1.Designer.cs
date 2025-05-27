
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            label1 = new Label();
            button2 = new Button();
            LogUser = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            panel2 = new Panel();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            label4 = new Label();
            LogPass = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(guna2ControlBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(976, 57);
            panel1.TabIndex = 0;
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.CustomizableEdges = customizableEdges1;
            guna2ControlBox1.FillColor = Color.FromArgb(139, 152, 166);
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(921, 4);
            guna2ControlBox1.Margin = new Padding(3, 4, 3, 4);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ControlBox1.Size = new Size(51, 39);
            guna2ControlBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 19);
            label1.Name = "label1";
            label1.Size = new Size(99, 16);
            label1.TabIndex = 3;
            label1.Text = "Leveling Corp.";
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.pngtree_youth_geometric_gradient_architectural_silhouette_inspirational_picture_image_976352;
            button2.Location = new Point(99, 344);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(258, 63);
            button2.TabIndex = 1;
            button2.Text = "LOG IN";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // LogUser
            // 
            LogUser.CustomizableEdges = customizableEdges3;
            LogUser.DefaultText = "";
            LogUser.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            LogUser.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            LogUser.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            LogUser.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            LogUser.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            LogUser.Font = new Font("Segoe UI", 9F);
            LogUser.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            LogUser.Location = new Point(35, 161);
            LogUser.Margin = new Padding(3, 5, 3, 5);
            LogUser.Name = "LogUser";
            LogUser.PlaceholderText = "";
            LogUser.SelectedText = "";
            LogUser.ShadowDecoration.CustomizableEdges = customizableEdges4;
            LogUser.Size = new Size(376, 39);
            LogUser.TabIndex = 2;
            LogUser.TextChanged += LogEmail_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 128, 0);
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(199, 35);
            label2.Name = "label2";
            label2.Size = new Size(53, 22);
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
            panel2.Controls.Add(linkLabel2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(LogPass);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(LogUser);
            panel2.Location = new Point(14, 140);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(463, 635);
            panel2.TabIndex = 4;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Transparent;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.LinkColor = Color.Red;
            linkLabel1.Location = new Point(39, 290);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(118, 20);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = SystemColors.Control;
            linkLabel2.LinkColor = SystemColors.ActiveCaptionText;
            linkLabel2.Location = new Point(160, 431);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(144, 20);
            linkLabel2.TabIndex = 9;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Create New Account";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.InactiveBorder;
            label4.Location = new Point(35, 219);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 7;
            label4.Text = "Password";
            // 
            // LogPass
            // 
            LogPass.CustomizableEdges = customizableEdges5;
            LogPass.DefaultText = "";
            LogPass.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            LogPass.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            LogPass.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            LogPass.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            LogPass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            LogPass.Font = new Font("Segoe UI", 9F);
            LogPass.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            LogPass.Location = new Point(35, 243);
            LogPass.Margin = new Padding(3, 5, 3, 5);
            LogPass.Name = "LogPass";
            LogPass.PlaceholderText = "";
            LogPass.SelectedText = "";
            LogPass.ShadowDecoration.CustomizableEdges = customizableEdges6;
            LogPass.Size = new Size(376, 39);
            LogPass.TabIndex = 6;
            LogPass.UseSystemPasswordChar = true;
            LogPass.TextChanged += LogPass_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Location = new Point(35, 137);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(581, 189);
            panel3.Name = "panel3";
            panel3.Size = new Size(310, 299);
            panel3.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dean5;
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(309, 296);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(976, 875);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            TransparencyKey = Color.DimGray;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button2;
        private Guna.UI2.WinForms.Guna2TextBox LogUser;
        private Label label2;
        private Panel panel2;
        private Label label4;
        private Guna.UI2.WinForms.Guna2TextBox LogPass;
        private Label label3;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Panel panel3;
        private PictureBox pictureBox1;
    }
}
