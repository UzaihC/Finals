namespace Finals
{
    partial class Form4
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
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(20, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(466, 528);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.Font = new Font("OCR A Extended", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(42, 277);
            button2.Name = "button2";
            button2.Size = new Size(380, 116);
            button2.TabIndex = 2;
            button2.Text = "MAKE A DONATION";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("OCR A Extended", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(42, 92);
            button1.Name = "button1";
            button1.Size = new Size(380, 116);
            button1.TabIndex = 1;
            button1.Text = "GO TO DASHBOARD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(67, 11);
            label1.Name = "label1";
            label1.Size = new Size(334, 30);
            label1.TabIndex = 0;
            label1.Text = "WELCOM TO LEVELING CORP";
            label1.Click += label1_Click;
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.CustomizableEdges = customizableEdges1;
            guna2ControlBox1.FillColor = Color.FromArgb(139, 152, 166);
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(452, 5);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ControlBox1.Size = new Size(45, 29);
            guna2ControlBox1.TabIndex = 1;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 597);
            Controls.Add(guna2ControlBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form4";
            Text = "Form4";
            TransparencyKey = Color.White;
            Load += Form4_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button2;
        private Button button1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}