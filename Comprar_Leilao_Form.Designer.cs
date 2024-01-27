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
            SuspendLayout();
            // 
            // email_vendedor
            // 
            email_vendedor.AutoSize = true;
            email_vendedor.Location = new Point(373, 40);
            email_vendedor.Name = "email_vendedor";
            email_vendedor.Size = new Size(91, 15);
            email_vendedor.TabIndex = 0;
            email_vendedor.Text = "email_vendedor";
            email_vendedor.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 116);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 1;
            label2.Text = "preco_atual";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(608, 116);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 2;
            label3.Text = "preco_minimo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(155, 201);
            label4.Name = "label4";
            label4.Size = new Size(111, 15);
            label4.TabIndex = 3;
            label4.Text = "tempo para decrem";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(594, 213);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 4;
            label5.Text = "Preco dpx";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(373, 259);
            label6.Name = "label6";
            label6.Size = new Size(119, 15);
            label6.TabIndex = 5;
            label6.Text = "tempo até leilão abrir";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(64, 40);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 6;
            label7.Text = "estado:";
            label7.Click += label7_Click;
            // 
            // button1
            // 
            button1.Location = new Point(277, 317);
            button1.Name = "button1";
            button1.Size = new Size(275, 74);
            button1.TabIndex = 7;
            button1.Text = "COMPRAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Comprar_Leilao_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}