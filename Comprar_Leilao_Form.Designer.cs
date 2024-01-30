namespace SpinToWin
{
    partial class Comprar_Leilao_Form
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
            email_vendedor = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // email_vendedor
            // 
            email_vendedor.AutoSize = true;
            email_vendedor.Location = new Point(12, 93);
            email_vendedor.Name = "email_vendedor";
            email_vendedor.Size = new Size(63, 15);
            email_vendedor.TabIndex = 0;
            email_vendedor.Text = "Vendedor: ";
            email_vendedor.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Preço atual: ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 2;
            label3.Text = "Preço mínimo: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(215, 67);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 3;
            label4.Text = "Tempo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(608, 19);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 4;
            label5.Text = "Preco dpx";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(132, 40);
            label6.Name = "label6";
            label6.Size = new Size(126, 15);
            label6.TabIndex = 5;
            label6.Text = "Tempo até leilão abrir: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 6;
            label7.Text = "Estado:";
            label7.Click += label7_Click;
            // 
            // button1
            // 
            button1.Location = new Point(781, 459);
            button1.Name = "button1";
            button1.Size = new Size(275, 74);
            button1.TabIndex = 7;
            button1.Text = "COMPRAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1044, 238);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(182, 364);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(295, 187);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Comprar_Leilao_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 559);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(email_vendedor);
            Name = "Comprar_Leilao_Form";
            Text = "Comprar_Leilao_Form";
            Load += Comprar_Leilao_Form_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label email_vendedor;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
    }
}