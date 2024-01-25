namespace SpinToWin
{
    partial class Ajuda_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ajuda_Form));
            button1 = new Button();
            label1 = new Label();
            perfil_button = new Button();
            logout_button = new Button();
            btn_vender = new Button();
            ajuda_button = new Button();
            btn_leiloes = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(1263, 9);
            button1.Name = "button1";
            button1.Size = new Size(30, 23);
            button1.TabIndex = 26;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(28, 38);
            label1.Name = "label1";
            label1.Size = new Size(230, 54);
            label1.TabIndex = 25;
            label1.Text = "Spin to Win";
            // 
            // perfil_button
            // 
            perfil_button.Location = new Point(1178, 38);
            perfil_button.Name = "perfil_button";
            perfil_button.Size = new Size(58, 50);
            perfil_button.TabIndex = 23;
            perfil_button.Text = "Perfil";
            perfil_button.UseVisualStyleBackColor = true;
            perfil_button.Click += perfil_button_Click;
            // 
            // logout_button
            // 
            logout_button.Location = new Point(1057, 38);
            logout_button.Name = "logout_button";
            logout_button.Size = new Size(115, 50);
            logout_button.TabIndex = 22;
            logout_button.Text = "Login";
            logout_button.UseVisualStyleBackColor = true;
            logout_button.Click += logout_button_Click;
            // 
            // btn_vender
            // 
            btn_vender.Location = new Point(752, 38);
            btn_vender.Name = "btn_vender";
            btn_vender.Size = new Size(228, 50);
            btn_vender.TabIndex = 21;
            btn_vender.Text = "Criar leilão";
            btn_vender.UseVisualStyleBackColor = true;
            btn_vender.Click += btn_vender_Click;
            // 
            // ajuda_button
            // 
            ajuda_button.Location = new Point(518, 38);
            ajuda_button.Name = "ajuda_button";
            ajuda_button.Size = new Size(228, 50);
            ajuda_button.TabIndex = 20;
            ajuda_button.Text = "Ajuda";
            ajuda_button.UseVisualStyleBackColor = true;
            // 
            // btn_leiloes
            // 
            btn_leiloes.Location = new Point(284, 38);
            btn_leiloes.Name = "btn_leiloes";
            btn_leiloes.Size = new Size(228, 50);
            btn_leiloes.TabIndex = 19;
            btn_leiloes.Text = "Leilões";
            btn_leiloes.UseVisualStyleBackColor = true;
            btn_leiloes.Click += btn_leiloes_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(28, 134);
            label2.Name = "label2";
            label2.Size = new Size(473, 46);
            label2.TabIndex = 27;
            label2.Text = "Q: Como posso comprar vinis?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(28, 194);
            label3.Name = "label3";
            label3.Size = new Size(1038, 128);
            label3.TabIndex = 28;
            label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(28, 379);
            label4.Name = "label4";
            label4.Size = new Size(965, 224);
            label4.TabIndex = 30;
            label4.Text = resources.GetString("label4.Text");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(28, 322);
            label5.Name = "label5";
            label5.Size = new Size(450, 46);
            label5.TabIndex = 29;
            label5.Text = "Q: Como posso vender vinis?";
            // 
            // Ajuda_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1306, 723);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(perfil_button);
            Controls.Add(logout_button);
            Controls.Add(btn_vender);
            Controls.Add(ajuda_button);
            Controls.Add(btn_leiloes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ajuda_Form";
            Text = "Ajuda_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label1;
        private Button perfil_button;
        private Button logout_button;
        private Button btn_vender;
        private Button ajuda_button;
        private Button btn_leiloes;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}