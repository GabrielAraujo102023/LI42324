namespace SpinToWin
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button2 = new Button();
            registar_button = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.Location = new Point(311, 437);
            button1.Name = "button1";
            button1.Size = new Size(90, 38);
            button1.TabIndex = 16;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(311, 380);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 15;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(311, 321);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 14;
            label2.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(402, 8);
            label1.Name = "label1";
            label1.Size = new Size(121, 44);
            label1.TabIndex = 13;
            label1.Text = "Login";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(311, 408);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(300, 23);
            textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(311, 345);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 23);
            textBox1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(311, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 257);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 500);
            panel1.TabIndex = 9;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.Location = new Point(521, 437);
            button2.Name = "button2";
            button2.Size = new Size(90, 38);
            button2.TabIndex = 17;
            button2.Text = "Login as Guest";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // registar_button
            // 
            registar_button.Location = new Point(416, 437);
            registar_button.Name = "registar_button";
            registar_button.Size = new Size(90, 38);
            registar_button.TabIndex = 18;
            registar_button.Text = "Register";
            registar_button.UseVisualStyleBackColor = true;
            registar_button.Click += registar_button_Click;
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 500);
            Controls.Add(button2);
            Controls.Add(registar_button);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login_Form";
            Text = "Form2";
            Load += Login_Form_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button2;
        private Button registar_button;
    }
}