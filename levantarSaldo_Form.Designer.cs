namespace SpinToWin
{
    partial class levantarSaldo_Form
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
            levantar_button = new Button();
            sair_button = new Button();
            iban_textBox = new TextBox();
            valor_textBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // levantar_button
            // 
            levantar_button.Location = new Point(57, 186);
            levantar_button.Name = "levantar_button";
            levantar_button.Size = new Size(100, 45);
            levantar_button.TabIndex = 0;
            levantar_button.Text = "Levantar";
            levantar_button.UseVisualStyleBackColor = true;
            levantar_button.Click += levantar_button_Click;
            // 
            // sair_button
            // 
            sair_button.Location = new Point(193, 12);
            sair_button.Name = "sair_button";
            sair_button.Size = new Size(23, 23);
            sair_button.TabIndex = 1;
            sair_button.Text = "X";
            sair_button.UseVisualStyleBackColor = true;
            sair_button.Click += sair_button_Click;
            // 
            // iban_textBox
            // 
            iban_textBox.Location = new Point(12, 53);
            iban_textBox.Name = "iban_textBox";
            iban_textBox.Size = new Size(204, 23);
            iban_textBox.TabIndex = 2;
            // 
            // valor_textBox
            // 
            valor_textBox.Location = new Point(12, 118);
            valor_textBox.Name = "valor_textBox";
            valor_textBox.Size = new Size(100, 23);
            valor_textBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 4;
            label1.Text = "IBAN:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 100);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 5;
            label2.Text = "Valor:";
            // 
            // levantarSaldo_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(228, 280);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(valor_textBox);
            Controls.Add(iban_textBox);
            Controls.Add(sair_button);
            Controls.Add(levantar_button);
            FormBorderStyle = FormBorderStyle.None;
            Name = "levantarSaldo_Form";
            Text = "levantarSaldo_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button levantar_button;
        private Button sair_button;
        private TextBox iban_textBox;
        private TextBox valor_textBox;
        private Label label1;
        private Label label2;
    }
}