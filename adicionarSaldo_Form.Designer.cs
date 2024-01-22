namespace SpinToWin
{
    partial class adicionarSaldo_Form
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
            sair_button = new Button();
            cartao_button = new Button();
            transferencia_button = new Button();
            numeroCartao_label = new Label();
            dataValidade_label = new Label();
            cvc_label = new Label();
            cvc_textBox = new TextBox();
            dataValidade_textBox = new TextBox();
            numeroCartao_textBox = new TextBox();
            concluir_button = new Button();
            valor_label = new Label();
            valor_textBox = new TextBox();
            entidade_label = new Label();
            dataLimite_label = new Label();
            referencia_label = new Label();
            SuspendLayout();
            // 
            // sair_button
            // 
            sair_button.Location = new Point(187, 12);
            sair_button.Name = "sair_button";
            sair_button.Size = new Size(27, 31);
            sair_button.TabIndex = 0;
            sair_button.Text = "X";
            sair_button.UseVisualStyleBackColor = true;
            sair_button.Click += sair_button_Click;
            // 
            // cartao_button
            // 
            cartao_button.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cartao_button.Location = new Point(45, 70);
            cartao_button.Name = "cartao_button";
            cartao_button.Size = new Size(135, 56);
            cartao_button.TabIndex = 1;
            cartao_button.Text = "Cartão";
            cartao_button.UseVisualStyleBackColor = true;
            cartao_button.Click += cartao_button_Click;
            // 
            // transferencia_button
            // 
            transferencia_button.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            transferencia_button.Location = new Point(45, 146);
            transferencia_button.Name = "transferencia_button";
            transferencia_button.Size = new Size(135, 62);
            transferencia_button.TabIndex = 2;
            transferencia_button.Text = "TransferênciaBancária";
            transferencia_button.UseVisualStyleBackColor = true;
            transferencia_button.Click += transferencia_button_Click;
            // 
            // numeroCartao_label
            // 
            numeroCartao_label.AutoSize = true;
            numeroCartao_label.Location = new Point(12, 40);
            numeroCartao_label.Name = "numeroCartao_label";
            numeroCartao_label.Size = new Size(106, 15);
            numeroCartao_label.TabIndex = 3;
            numeroCartao_label.Text = "Número de cartão:";
            numeroCartao_label.Visible = false;
            // 
            // dataValidade_label
            // 
            dataValidade_label.AutoSize = true;
            dataValidade_label.Location = new Point(12, 80);
            dataValidade_label.Name = "dataValidade_label";
            dataValidade_label.Size = new Size(97, 15);
            dataValidade_label.TabIndex = 4;
            dataValidade_label.Text = "Data de validade:";
            dataValidade_label.Visible = false;
            // 
            // cvc_label
            // 
            cvc_label.AutoSize = true;
            cvc_label.Location = new Point(12, 129);
            cvc_label.Name = "cvc_label";
            cvc_label.Size = new Size(33, 15);
            cvc_label.TabIndex = 5;
            cvc_label.Text = "CVC:";
            cvc_label.Visible = false;
            // 
            // cvc_textBox
            // 
            cvc_textBox.Location = new Point(12, 147);
            cvc_textBox.Name = "cvc_textBox";
            cvc_textBox.Size = new Size(33, 23);
            cvc_textBox.TabIndex = 6;
            cvc_textBox.Visible = false;
            // 
            // dataValidade_textBox
            // 
            dataValidade_textBox.Location = new Point(12, 103);
            dataValidade_textBox.Name = "dataValidade_textBox";
            dataValidade_textBox.Size = new Size(63, 23);
            dataValidade_textBox.TabIndex = 7;
            dataValidade_textBox.Visible = false;
            // 
            // numeroCartao_textBox
            // 
            numeroCartao_textBox.Location = new Point(12, 58);
            numeroCartao_textBox.Name = "numeroCartao_textBox";
            numeroCartao_textBox.Size = new Size(168, 23);
            numeroCartao_textBox.TabIndex = 8;
            numeroCartao_textBox.Visible = false;
            // 
            // concluir_button
            // 
            concluir_button.Location = new Point(69, 230);
            concluir_button.Name = "concluir_button";
            concluir_button.Size = new Size(75, 23);
            concluir_button.TabIndex = 9;
            concluir_button.Text = "Concluir";
            concluir_button.UseVisualStyleBackColor = true;
            concluir_button.Visible = false;
            concluir_button.Click += concluir_button_Click;
            // 
            // valor_label
            // 
            valor_label.AutoSize = true;
            valor_label.Location = new Point(12, 167);
            valor_label.Name = "valor_label";
            valor_label.Size = new Size(36, 15);
            valor_label.TabIndex = 10;
            valor_label.Text = "Valor:";
            valor_label.Visible = false;
            // 
            // valor_textBox
            // 
            valor_textBox.Location = new Point(12, 185);
            valor_textBox.Name = "valor_textBox";
            valor_textBox.Size = new Size(100, 23);
            valor_textBox.TabIndex = 11;
            valor_textBox.Visible = false;
            // 
            // entidade_label
            // 
            entidade_label.AutoSize = true;
            entidade_label.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            entidade_label.Location = new Point(12, 40);
            entidade_label.Name = "entidade_label";
            entidade_label.Size = new Size(90, 25);
            entidade_label.TabIndex = 12;
            entidade_label.Text = "Entidade: ";
            entidade_label.Visible = false;
            // 
            // dataLimite_label
            // 
            dataLimite_label.AutoSize = true;
            dataLimite_label.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dataLimite_label.Location = new Point(12, 144);
            dataLimite_label.Name = "dataLimite_label";
            dataLimite_label.Size = new Size(106, 25);
            dataLimite_label.TabIndex = 13;
            dataLimite_label.Text = "Data limite: ";
            dataLimite_label.Visible = false;
            dataLimite_label.Click += label2_Click;
            // 
            // referencia_label
            // 
            referencia_label.AutoSize = true;
            referencia_label.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            referencia_label.Location = new Point(12, 95);
            referencia_label.Name = "referencia_label";
            referencia_label.Size = new Size(101, 25);
            referencia_label.TabIndex = 14;
            referencia_label.Text = "Referência: ";
            referencia_label.Visible = false;
            // 
            // adicionarSaldo_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(226, 265);
            Controls.Add(referencia_label);
            Controls.Add(dataLimite_label);
            Controls.Add(entidade_label);
            Controls.Add(valor_textBox);
            Controls.Add(valor_label);
            Controls.Add(concluir_button);
            Controls.Add(numeroCartao_textBox);
            Controls.Add(dataValidade_textBox);
            Controls.Add(cvc_textBox);
            Controls.Add(cvc_label);
            Controls.Add(dataValidade_label);
            Controls.Add(numeroCartao_label);
            Controls.Add(transferencia_button);
            Controls.Add(cartao_button);
            Controls.Add(sair_button);
            FormBorderStyle = FormBorderStyle.None;
            Name = "adicionarSaldo_Form";
            Text = "adicionarSaldo_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sair_button;
        private Button cartao_button;
        private Button transferencia_button;
        private Label numeroCartao_label;
        private Label dataValidade_label;
        private Label cvc_label;
        private TextBox cvc_textBox;
        private TextBox dataValidade_textBox;
        private TextBox numeroCartao_textBox;
        private Button concluir_button;
        private Label valor_label;
        private TextBox valor_textBox;
        private Label entidade_label;
        private Label dataLimite_label;
        private Label referencia_label;
    }
}