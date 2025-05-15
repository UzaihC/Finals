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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(15, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(534, 566);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.OrangeRed;
            button3.Font = new Font("OCR A Extended", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(155, 344);
            button3.Name = "button3";
            button3.Size = new Size(164, 42);
            button3.TabIndex = 10;
            button3.Text = "CONTINUE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(33, 249);
            button2.Name = "button2";
            button2.Size = new Size(137, 27);
            button2.TabIndex = 9;
            button2.Text = "Show Password";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(34, 170);
            button1.Name = "button1";
            button1.Size = new Size(137, 27);
            button1.TabIndex = 8;
            button1.Text = "Show Password";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("OCR A Extended", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 200);
            label3.Name = "label3";
            label3.Size = new Size(147, 13);
            label3.TabIndex = 7;
            label3.Text = "Confirm New Password";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(33, 220);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(456, 23);
            textBox2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("OCR A Extended", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 121);
            label2.Name = "label2";
            label2.Size = new Size(91, 13);
            label2.TabIndex = 5;
            label2.Text = "New Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(33, 141);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(456, 23);
            textBox1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Desktop;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(534, 71);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("OCR A Extended", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(155, 29);
            label1.Name = "label1";
            label1.Size = new Size(237, 25);
            label1.TabIndex = 0;
            label1.Text = "FORGOT PASSWORD";
            // 
            // Password
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pngtree_youth_geometric_gradient_architectural_silhouette_inspirational_picture_image_976352;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(566, 601);
            Controls.Add(panel1);
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
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Button button2;
        private Button button1;
        private Button button3;
    }
}