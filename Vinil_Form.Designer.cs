namespace SpinToWin
{
    partial class Vinil_Form
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
            label1 = new Label();
            artista_textBox = new TextBox();
            nome_textBox = new TextBox();
            label2 = new Label();
            ano_textBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            disco_comboBo = new ComboBox();
            capa_comboBox = new ComboBox();
            label5 = new Label();
            categoria_comboBox = new ComboBox();
            label6 = new Label();
            duracao_textBox = new TextBox();
            label7 = new Label();
            tamanho_comboBox = new ComboBox();
            label8 = new Label();
            rotacoes_comboBox = new ComboBox();
            label9 = new Label();
            tipo_comboBox = new ComboBox();
            label10 = new Label();
            gravadora_textBox = new TextBox();
            label11 = new Label();
            edicaoEspecial_checkBox = new CheckBox();
            remasterizado_checkBox = new CheckBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button3 = new Button();
            url_textBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // sair_button
            // 
            sair_button.Location = new Point(763, 12);
            sair_button.Name = "sair_button";
            sair_button.Size = new Size(25, 23);
            sair_button.TabIndex = 0;
            sair_button.Text = "X";
            sair_button.UseVisualStyleBackColor = true;
            sair_button.Click += sair_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "Artista:";
            // 
            // artista_textBox
            // 
            artista_textBox.Location = new Point(12, 32);
            artista_textBox.Name = "artista_textBox";
            artista_textBox.Size = new Size(171, 23);
            artista_textBox.TabIndex = 2;
            // 
            // nome_textBox
            // 
            nome_textBox.Location = new Point(12, 85);
            nome_textBox.Name = "nome_textBox";
            nome_textBox.Size = new Size(171, 23);
            nome_textBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 3;
            label2.Text = "Nome:";
            // 
            // ano_textBox
            // 
            ano_textBox.Location = new Point(12, 141);
            ano_textBox.MaxLength = 4;
            ano_textBox.Name = "ano_textBox";
            ano_textBox.Size = new Size(56, 23);
            ano_textBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 123);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 5;
            label3.Text = "Ano de lançamento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 176);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 7;
            label4.Text = "Condição do disco:";
            // 
            // disco_comboBo
            // 
            disco_comboBo.FormattingEnabled = true;
            disco_comboBo.Items.AddRange(new object[] { "Excelente", "Boa", "Razoável", "Má", "Terrível" });
            disco_comboBo.Location = new Point(12, 194);
            disco_comboBo.Name = "disco_comboBo";
            disco_comboBo.Size = new Size(121, 23);
            disco_comboBo.TabIndex = 8;
            // 
            // capa_comboBox
            // 
            capa_comboBox.FormattingEnabled = true;
            capa_comboBox.Items.AddRange(new object[] { "Excelente", "Boa", "Razoável", "Má", "Terrível" });
            capa_comboBox.Location = new Point(12, 249);
            capa_comboBox.Name = "capa_comboBox";
            capa_comboBox.Size = new Size(121, 23);
            capa_comboBox.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 231);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 9;
            label5.Text = "Condição da capa:";
            // 
            // categoria_comboBox
            // 
            categoria_comboBox.FormattingEnabled = true;
            categoria_comboBox.Items.AddRange(new object[] { "Blues", "Classical", "Country", "Disco", "Electronic", "Folk", "Funk", "Hip-hop", "Jazz", "Latin", "Metal", "Pop", "Punk", "Rap", "Reggae", "Rock", "Soul", "Ambient", "Bluegrass", "Blues-rock", "Chamber music", "Choral", "Dance", "Gospel", "House", "Indie", "New wave", "R&B", "Reggaeton", "Techno", "Trance" });
            categoria_comboBox.Location = new Point(12, 304);
            categoria_comboBox.Name = "categoria_comboBox";
            categoria_comboBox.Size = new Size(121, 23);
            categoria_comboBox.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 286);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 11;
            label6.Text = "Categoria:";
            // 
            // duracao_textBox
            // 
            duracao_textBox.Location = new Point(12, 358);
            duracao_textBox.Name = "duracao_textBox";
            duracao_textBox.Size = new Size(56, 23);
            duracao_textBox.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 340);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 13;
            label7.Text = "Duração:";
            // 
            // tamanho_comboBox
            // 
            tamanho_comboBox.FormattingEnabled = true;
            tamanho_comboBox.Items.AddRange(new object[] { "16", "12", "10", "7" });
            tamanho_comboBox.Location = new Point(12, 415);
            tamanho_comboBox.Name = "tamanho_comboBox";
            tamanho_comboBox.Size = new Size(121, 23);
            tamanho_comboBox.TabIndex = 16;
            tamanho_comboBox.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 397);
            label8.Name = "label8";
            label8.Size = new Size(80, 15);
            label8.TabIndex = 15;
            label8.Text = "Tamanho (in):";
            // 
            // rotacoes_comboBox
            // 
            rotacoes_comboBox.FormattingEnabled = true;
            rotacoes_comboBox.Items.AddRange(new object[] { "33", "45", "78" });
            rotacoes_comboBox.Location = new Point(353, 32);
            rotacoes_comboBox.Name = "rotacoes_comboBox";
            rotacoes_comboBox.Size = new Size(121, 23);
            rotacoes_comboBox.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(353, 14);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 17;
            label9.Text = "Rotações:";
            // 
            // tipo_comboBox
            // 
            tipo_comboBox.FormattingEnabled = true;
            tipo_comboBox.Items.AddRange(new object[] { "Transcrição", "Single", "EP", "LP" });
            tipo_comboBox.Location = new Point(353, 85);
            tipo_comboBox.Name = "tipo_comboBox";
            tipo_comboBox.Size = new Size(121, 23);
            tipo_comboBox.TabIndex = 20;
            tipo_comboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(353, 67);
            label10.Name = "label10";
            label10.Size = new Size(33, 15);
            label10.TabIndex = 19;
            label10.Text = "Tipo:";
            // 
            // gravadora_textBox
            // 
            gravadora_textBox.Location = new Point(353, 141);
            gravadora_textBox.Name = "gravadora_textBox";
            gravadora_textBox.Size = new Size(171, 23);
            gravadora_textBox.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(353, 123);
            label11.Name = "label11";
            label11.Size = new Size(64, 15);
            label11.TabIndex = 21;
            label11.Text = "Gravadora:";
            // 
            // edicaoEspecial_checkBox
            // 
            edicaoEspecial_checkBox.AutoSize = true;
            edicaoEspecial_checkBox.Location = new Point(353, 194);
            edicaoEspecial_checkBox.Name = "edicaoEspecial_checkBox";
            edicaoEspecial_checkBox.Size = new Size(106, 19);
            edicaoEspecial_checkBox.TabIndex = 23;
            edicaoEspecial_checkBox.Text = "Edição Especial";
            edicaoEspecial_checkBox.UseVisualStyleBackColor = true;
            // 
            // remasterizado_checkBox
            // 
            remasterizado_checkBox.AutoSize = true;
            remasterizado_checkBox.Location = new Point(353, 251);
            remasterizado_checkBox.Name = "remasterizado_checkBox";
            remasterizado_checkBox.Size = new Size(103, 19);
            remasterizado_checkBox.TabIndex = 24;
            remasterizado_checkBox.Text = "Remasterizado";
            remasterizado_checkBox.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(533, 277);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(241, 161);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(594, 249);
            button1.Name = "button1";
            button1.Size = new Size(101, 23);
            button1.TabIndex = 26;
            button1.Text = "Carregar foto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(336, 358);
            button3.Name = "button3";
            button3.Size = new Size(148, 70);
            button3.TabIndex = 29;
            button3.Text = "Adicionar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // url_textBox
            // 
            url_textBox.Location = new Point(533, 223);
            url_textBox.Name = "url_textBox";
            url_textBox.PlaceholderText = "URL da imagem";
            url_textBox.Size = new Size(241, 23);
            url_textBox.TabIndex = 30;
            // 
            // Vinil_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(url_textBox);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(remasterizado_checkBox);
            Controls.Add(edicaoEspecial_checkBox);
            Controls.Add(gravadora_textBox);
            Controls.Add(label11);
            Controls.Add(tipo_comboBox);
            Controls.Add(label10);
            Controls.Add(rotacoes_comboBox);
            Controls.Add(label9);
            Controls.Add(tamanho_comboBox);
            Controls.Add(label8);
            Controls.Add(duracao_textBox);
            Controls.Add(label7);
            Controls.Add(categoria_comboBox);
            Controls.Add(label6);
            Controls.Add(capa_comboBox);
            Controls.Add(label5);
            Controls.Add(disco_comboBo);
            Controls.Add(label4);
            Controls.Add(ano_textBox);
            Controls.Add(label3);
            Controls.Add(nome_textBox);
            Controls.Add(label2);
            Controls.Add(artista_textBox);
            Controls.Add(label1);
            Controls.Add(sair_button);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Vinil_Form";
            Text = "Vinil_Form";
            Load += Vinil_Form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sair_button;
        private Label label1;
        private TextBox artista_textBox;
        private TextBox nome_textBox;
        private Label label2;
        private TextBox ano_textBox;
        private Label label3;
        private Label label4;
        private ComboBox disco_comboBo;
        private ComboBox capa_comboBox;
        private Label label5;
        private ComboBox categoria_comboBox;
        private Label label6;
        private TextBox duracao_textBox;
        private Label label7;
        private ComboBox tamanho_comboBox;
        private Label label8;
        private ComboBox rotacoes_comboBox;
        private Label label9;
        private ComboBox tipo_comboBox;
        private Label label10;
        private TextBox gravadora_textBox;
        private Label label11;
        private CheckBox edicaoEspecial_checkBox;
        private CheckBox remasterizado_checkBox;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button3;
        private TextBox url_textBox;
    }
}