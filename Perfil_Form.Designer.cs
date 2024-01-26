namespace SpinToWin
{
    partial class Perfil_Form
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
            accountName_label = new Label();
            saldo_label = new Label();
            adicionarSaldo_button = new Button();
            label1 = new Label();
            leiloesComprados_label = new Label();
            leiloesVendidos_label = new Label();
            generoComprado_label = new Label();
            generoVendido_label = new Label();
            totalGasto_label = new Label();
            totalGanho_label = new Label();
            lucro_label = new Label();
            Voltar_button = new Button();
            levantar_button = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // accountName_label
            // 
            accountName_label.AutoSize = true;
            accountName_label.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            accountName_label.Location = new Point(12, 37);
            accountName_label.Name = "accountName_label";
            accountName_label.Size = new Size(130, 54);
            accountName_label.TabIndex = 0;
            accountName_label.Text = "label1";
            // 
            // saldo_label
            // 
            saldo_label.AutoSize = true;
            saldo_label.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            saldo_label.Location = new Point(12, 91);
            saldo_label.Name = "saldo_label";
            saldo_label.Size = new Size(66, 28);
            saldo_label.TabIndex = 1;
            saldo_label.Text = "Saldo:";
            // 
            // adicionarSaldo_button
            // 
            adicionarSaldo_button.Location = new Point(12, 122);
            adicionarSaldo_button.Name = "adicionarSaldo_button";
            adicionarSaldo_button.Size = new Size(75, 38);
            adicionarSaldo_button.TabIndex = 3;
            adicionarSaldo_button.Text = "Adicionar Saldo";
            adicionarSaldo_button.UseVisualStyleBackColor = true;
            adicionarSaldo_button.Click += adicionarSaldo_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 182);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 4;
            label1.Text = "Estatísticas:";
            // 
            // leiloesComprados_label
            // 
            leiloesComprados_label.AutoSize = true;
            leiloesComprados_label.Location = new Point(12, 207);
            leiloesComprados_label.Name = "leiloesComprados_label";
            leiloesComprados_label.Size = new Size(112, 15);
            leiloesComprados_label.TabIndex = 5;
            leiloesComprados_label.Text = "Leilões comprados: ";
            // 
            // leiloesVendidos_label
            // 
            leiloesVendidos_label.AutoSize = true;
            leiloesVendidos_label.Location = new Point(12, 232);
            leiloesVendidos_label.Name = "leiloesVendidos_label";
            leiloesVendidos_label.Size = new Size(97, 15);
            leiloesVendidos_label.TabIndex = 6;
            leiloesVendidos_label.Text = "Leilões vendidos ";
            // 
            // generoComprado_label
            // 
            generoComprado_label.AutoSize = true;
            generoComprado_label.Location = new Point(12, 260);
            generoComprado_label.Name = "generoComprado_label";
            generoComprado_label.Size = new Size(137, 15);
            generoComprado_label.TabIndex = 7;
            generoComprado_label.Text = "Género mais comprado: ";
            // 
            // generoVendido_label
            // 
            generoVendido_label.AutoSize = true;
            generoVendido_label.Location = new Point(12, 290);
            generoVendido_label.Name = "generoVendido_label";
            generoVendido_label.Size = new Size(125, 15);
            generoVendido_label.TabIndex = 8;
            generoVendido_label.Text = "Género mais vendido: ";
            // 
            // totalGasto_label
            // 
            totalGasto_label.AutoSize = true;
            totalGasto_label.Location = new Point(12, 320);
            totalGasto_label.Name = "totalGasto_label";
            totalGasto_label.Size = new Size(70, 15);
            totalGasto_label.TabIndex = 9;
            totalGasto_label.Text = "Total gasto: ";
            // 
            // totalGanho_label
            // 
            totalGanho_label.AutoSize = true;
            totalGanho_label.Location = new Point(12, 354);
            totalGanho_label.Name = "totalGanho_label";
            totalGanho_label.Size = new Size(75, 15);
            totalGanho_label.TabIndex = 10;
            totalGanho_label.Text = "Total ganho: ";
            // 
            // lucro_label
            // 
            lucro_label.AutoSize = true;
            lucro_label.Location = new Point(12, 382);
            lucro_label.Name = "lucro_label";
            lucro_label.Size = new Size(43, 15);
            lucro_label.TabIndex = 11;
            lucro_label.Text = "Lucro: ";
            // 
            // Voltar_button
            // 
            Voltar_button.Location = new Point(758, 12);
            Voltar_button.Name = "Voltar_button";
            Voltar_button.Size = new Size(30, 23);
            Voltar_button.TabIndex = 12;
            Voltar_button.Text = "X";
            Voltar_button.UseVisualStyleBackColor = true;
            Voltar_button.Click += Voltar_button_Click;
            // 
            // levantar_button
            // 
            levantar_button.Location = new Point(93, 122);
            levantar_button.Name = "levantar_button";
            levantar_button.Size = new Size(75, 38);
            levantar_button.TabIndex = 13;
            levantar_button.Text = "Levantar Saldo";
            levantar_button.UseVisualStyleBackColor = true;
            levantar_button.Click += levantar_button_Click;
            // 
            // button1
            // 
            button1.Location = new Point(673, 392);
            button1.Name = "button1";
            button1.Size = new Size(115, 46);
            button1.TabIndex = 14;
            button1.Text = "Adicionar vinil";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Perfil_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(levantar_button);
            Controls.Add(Voltar_button);
            Controls.Add(lucro_label);
            Controls.Add(totalGanho_label);
            Controls.Add(totalGasto_label);
            Controls.Add(generoVendido_label);
            Controls.Add(generoComprado_label);
            Controls.Add(leiloesVendidos_label);
            Controls.Add(leiloesComprados_label);
            Controls.Add(label1);
            Controls.Add(adicionarSaldo_button);
            Controls.Add(saldo_label);
            Controls.Add(accountName_label);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Perfil_Form";
            Text = "Perfil_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label accountName_label;
        private Label saldo_label;
        private Button adicionarSaldo_button;
        private Label label1;
        private Label leiloesComprados_label;
        private Label leiloesVendidos_label;
        private Label generoComprado_label;
        private Label generoVendido_label;
        private Label totalGasto_label;
        private Label totalGanho_label;
        private Label lucro_label;
        private Button Voltar_button;
        private Button levantar_button;
        private Button button1;
    }
}