namespace Finals
{
    partial class Form5
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
            button2 = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtRecipient = new TextBox();
            txtAmount = new TextBox();
            txtEmail = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(14, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 547);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(381, 501);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(130, 33);
            button2.TabIndex = 3;
            button2.Text = "GO BACK";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logolevel;
            pictureBox1.Location = new Point(556, 114);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(311, 307);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtRecipient);
            panel2.Controls.Add(txtAmount);
            panel2.Controls.Add(txtEmail);
            panel2.Location = new Point(18, 95);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(501, 371);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.OrangeRed;
            button1.Font = new Font("OCR A Extended", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(62, 222);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(354, 80);
            button1.TabIndex = 6;
            button1.Text = "MAKE THE DONATION";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("OCR A Extended", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 147);
            label4.Name = "label4";
            label4.Size = new Size(89, 17);
            label4.TabIndex = 5;
            label4.Text = "Recipient";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("OCR A Extended", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 89);
            label3.Name = "label3";
            label3.Size = new Size(62, 17);
            label3.TabIndex = 4;
            label3.Text = "Amount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("OCR A Extended", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 28);
            label2.Name = "label2";
            label2.Size = new Size(98, 17);
            label2.TabIndex = 3;
            label2.Text = "Your Email";
            // 
            // txtRecipient
            // 
            txtRecipient.Location = new Point(17, 171);
            txtRecipient.Margin = new Padding(3, 4, 3, 4);
            txtRecipient.Name = "txtRecipient";
            txtRecipient.Size = new Size(445, 27);
            txtRecipient.TabIndex = 2;
            txtRecipient.TextChanged += textBox3_TextChanged;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(17, 113);
            txtAmount.Margin = new Padding(3, 4, 3, 4);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(445, 27);
            txtAmount.TabIndex = 1;
            txtAmount.TextChanged += textBox2_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(17, 52);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(445, 27);
            txtEmail.TabIndex = 0;
            txtEmail.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("OCR A Extended", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(282, 0);
            label1.Name = "label1";
            label1.Size = new Size(317, 29);
            label1.TabIndex = 0;
            label1.Text = "WELCOME TO DONATION";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pngtree_youth_geometric_gradient_architectural_silhouette_inspirational_picture_image_976352;
            ClientSize = new Size(914, 600);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private TextBox txtRecipient;
        private TextBox txtAmount;
        private TextBox txtEmail;
        private Label label2;
        private Button button1;
        private Label label4;
        private Label label3;
        private Button button2;
    }
}