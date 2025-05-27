namespace Finals
{
    partial class Loading
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Timer = new Guna.UI2.WinForms.Guna2Elipse(components);
            timer1 = new System.Windows.Forms.Timer(components);
            prog = new Guna.UI2.WinForms.Guna2ProgressBar();
            Lolo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Timer
            // 
            Timer.BorderRadius = 30;
            Timer.TargetControl = this;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // prog
            // 
            prog.CustomizableEdges = customizableEdges1;
            prog.Location = new Point(-1, 235);
            prog.Margin = new Padding(3, 4, 3, 4);
            prog.Name = "prog";
            prog.ShadowDecoration.CustomizableEdges = customizableEdges2;
            prog.Size = new Size(281, 40);
            prog.TabIndex = 0;
            prog.Text = "guna2ProgressBar1";
            prog.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            prog.ValueChanged += prog_ValueChanged;
            // 
            // Lolo
            // 
            Lolo.BackColor = Color.Transparent;
            Lolo.Location = new Point(130, 204);
            Lolo.Margin = new Padding(3, 4, 3, 4);
            Lolo.Name = "Lolo";
            Lolo.Size = new Size(23, 22);
            Lolo.TabIndex = 1;
            Lolo.Text = "0%";
            Lolo.Click += Lolo_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(10, 9);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 187);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dean5;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 187);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = panel1;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 30;
            guna2Elipse2.TargetControl = pictureBox1;
            // 
            // Loading
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 272);
            Controls.Add(panel1);
            Controls.Add(Lolo);
            Controls.Add(prog);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Loading";
            Text = "Loading";
            Load += Loading_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse Timer;
        private Guna.UI2.WinForms.Guna2ProgressBar prog;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lolo;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
    }
}