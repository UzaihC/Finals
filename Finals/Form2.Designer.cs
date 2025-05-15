namespace Finals
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            checkBox1 = new CheckBox();
            label4 = new Label();
            label2 = new Label();
            PassW = new Guna.UI2.WinForms.Guna2TextBox();
            button2 = new Button();
            label3 = new Label();
            EmailT = new Guna.UI2.WinForms.Guna2TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(817, 67);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.images;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(771, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(34, 32);
            panel3.TabIndex = 0;
            panel3.Paint += panel3_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonShadow;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(PassW);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(EmailT);
            panel2.Location = new Point(12, 111);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 414);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = SystemColors.ButtonFace;
            checkBox1.Location = new Point(48, 250);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(125, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "SHOW PASSWORD";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.InactiveBorder;
            label4.Location = new Point(46, 195);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 7;
            label4.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 128, 0);
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(185, 21);
            label2.Name = "label2";
            label2.Size = new Size(58, 17);
            label2.TabIndex = 3;
            label2.Text = "REGISTER";
            label2.Click += label2_Click;
            // 
            // PassW
            // 
            PassW.CustomizableEdges = customizableEdges1;
            PassW.DefaultText = "";
            PassW.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            PassW.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            PassW.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            PassW.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            PassW.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            PassW.Font = new Font("Segoe UI", 9F);
            PassW.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            PassW.Location = new Point(46, 213);
            PassW.Name = "PassW";
            PassW.PlaceholderText = "";
            PassW.SelectedText = "";
            PassW.ShadowDecoration.CustomizableEdges = customizableEdges2;
            PassW.Size = new Size(329, 29);
            PassW.TabIndex = 6;
            PassW.TextChanged += PassW_TextChanged;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.pngtree_youth_geometric_gradient_architectural_silhouette_inspirational_picture_image_976352;
            button2.Location = new Point(91, 295);
            button2.Name = "button2";
            button2.Size = new Size(226, 47);
            button2.TabIndex = 1;
            button2.Text = "REGISTER";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Location = new Point(46, 134);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // EmailT
            // 
            EmailT.CustomizableEdges = customizableEdges3;
            EmailT.DefaultText = "";
            EmailT.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            EmailT.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            EmailT.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            EmailT.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            EmailT.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            EmailT.Font = new Font("Segoe UI", 9F);
            EmailT.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            EmailT.Location = new Point(46, 152);
            EmailT.Name = "EmailT";
            EmailT.PlaceholderText = "";
            EmailT.SelectedText = "";
            EmailT.ShadowDecoration.CustomizableEdges = customizableEdges4;
            EmailT.Size = new Size(329, 29);
            EmailT.TabIndex = 2;
            EmailT.TextChanged += EmailT_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pngtree_youth_geometric_gradient_architectural_silhouette_inspirational_picture_image_976352;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(817, 674);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label4;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox PassW;
        private Button button2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox EmailT;
        private CheckBox checkBox1;
        private Panel panel3;
    }
}