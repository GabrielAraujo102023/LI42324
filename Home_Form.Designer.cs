namespace SpinToWin
{
    partial class Home_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_leiloes = new Button();
            ajuda_button = new Button();
            btn_vender = new Button();
            logout_button = new Button();
            perfil_button = new Button();
            button6 = new Button();
            label1 = new Label();
            pesquisar_button = new Button();
            txtBox_pesquisar = new TextBox();
            ordenar_combo = new ComboBox();
            comboBox2 = new ComboBox();
            button1 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            prevPage_button = new Button();
            nextPage_button = new Button();
            button2 = new Button();
            button3 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btn_leiloes
            // 
            btn_leiloes.Location = new Point(326, 47);
            btn_leiloes.Margin = new Padding(3, 4, 3, 4);
            btn_leiloes.Name = "btn_leiloes";
            btn_leiloes.Size = new Size(261, 67);
            btn_leiloes.TabIndex = 0;
            btn_leiloes.Text = "Leilões";
            btn_leiloes.UseVisualStyleBackColor = true;
            btn_leiloes.Click += button1_Click;
            // 
            // ajuda_button
            // 
            ajuda_button.Location = new Point(593, 47);
            ajuda_button.Margin = new Padding(3, 4, 3, 4);
            ajuda_button.Name = "ajuda_button";
            ajuda_button.Size = new Size(261, 67);
            ajuda_button.TabIndex = 1;
            ajuda_button.Text = "Ajuda";
            ajuda_button.UseVisualStyleBackColor = true;
            ajuda_button.Click += button2_Click;
            // 
            // btn_vender
            // 
            btn_vender.Location = new Point(861, 47);
            btn_vender.Margin = new Padding(3, 4, 3, 4);
            btn_vender.Name = "btn_vender";
            btn_vender.Size = new Size(261, 67);
            btn_vender.TabIndex = 2;
            btn_vender.Text = "Criar leilão";
            btn_vender.UseVisualStyleBackColor = true;
            btn_vender.Click += btn_vender_Click;
            // 
            // logout_button
            // 
            logout_button.Location = new Point(1209, 47);
            logout_button.Margin = new Padding(3, 4, 3, 4);
            logout_button.Name = "logout_button";
            logout_button.Size = new Size(131, 67);
            logout_button.TabIndex = 3;
            logout_button.Text = "Login";
            logout_button.UseVisualStyleBackColor = true;
            logout_button.Click += button4_Click;
            // 
            // perfil_button
            // 
            perfil_button.Location = new Point(1347, 47);
            perfil_button.Margin = new Padding(3, 4, 3, 4);
            perfil_button.Name = "perfil_button";
            perfil_button.Size = new Size(66, 67);
            perfil_button.TabIndex = 4;
            perfil_button.Text = "Perfil";
            perfil_button.UseVisualStyleBackColor = true;
            perfil_button.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(326, 121);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(211, 59);
            button6.TabIndex = 5;
            button6.Text = "testClienteDB";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(33, 47);
            label1.Name = "label1";
            label1.Size = new Size(286, 67);
            label1.TabIndex = 7;
            label1.Text = "Spin to Win";
            label1.Click += label1_Click;
            // 
            // pesquisar_button
            // 
            pesquisar_button.Location = new Point(3, 3);
            pesquisar_button.Margin = new Padding(3, 4, 3, 4);
            pesquisar_button.Name = "pesquisar_button";
            pesquisar_button.Size = new Size(86, 31);
            pesquisar_button.TabIndex = 10;
            pesquisar_button.Text = "pesquisar";
            pesquisar_button.UseVisualStyleBackColor = true;
            pesquisar_button.Click += pesquisar_button_Click;
            // 
            // txtBox_pesquisar
            // 
            txtBox_pesquisar.Location = new Point(182, 192);
            txtBox_pesquisar.Margin = new Padding(3, 4, 3, 4);
            txtBox_pesquisar.Name = "txtBox_pesquisar";
            txtBox_pesquisar.PlaceholderText = "Pesquisar leilão...";
            txtBox_pesquisar.Size = new Size(404, 27);
            txtBox_pesquisar.TabIndex = 11;
            // 
            // ordenar_combo
            // 
            ordenar_combo.FormattingEnabled = true;
            ordenar_combo.Items.AddRange(new object[] { "Preço (Asc.)", "Preço (Des.)", "Nº Vinis (Asc.)", "Nº Vinis (Des.)", "Tempo restante (Asc.)", "Tempo restante (Des.)" });
            ordenar_combo.Location = new Point(617, 191);
            ordenar_combo.Margin = new Padding(3, 4, 3, 4);
            ordenar_combo.Name = "ordenar_combo";
            ordenar_combo.Size = new Size(138, 28);
            ordenar_combo.TabIndex = 12;
            ordenar_combo.Text = "Ordenar por";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(762, 191);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(138, 28);
            comboBox2.TabIndex = 13;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(1445, 8);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(34, 31);
            button1.TabIndex = 14;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(pesquisar_button);
            panel1.Location = new Point(78, 188);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1351, 133);
            panel1.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Honeydew;
            panel2.Controls.Add(prevPage_button);
            panel2.Controls.Add(nextPage_button);
            panel2.Location = new Point(1390, 188);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(57, 799);
            panel2.TabIndex = 16;
            // 
            // prevPage_button
            // 
            prevPage_button.Location = new Point(10, 453);
            prevPage_button.Margin = new Padding(3, 4, 3, 4);
            prevPage_button.Name = "prevPage_button";
            prevPage_button.Size = new Size(39, 31);
            prevPage_button.TabIndex = 21;
            prevPage_button.Text = "<";
            prevPage_button.UseVisualStyleBackColor = true;
            // 
            // nextPage_button
            // 
            nextPage_button.Location = new Point(10, 359);
            nextPage_button.Margin = new Padding(3, 4, 3, 4);
            nextPage_button.Name = "nextPage_button";
            nextPage_button.Size = new Size(39, 31);
            nextPage_button.TabIndex = 20;
            nextPage_button.Text = ">";
            nextPage_button.UseVisualStyleBackColor = true;
            nextPage_button.Click += nextPage_button_Click;
            // 
            // button2
            // 
            button2.Location = new Point(577, 124);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(231, 53);
            button2.TabIndex = 17;
            button2.Text = "testVinilDB";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(842, 123);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(231, 60);
            button3.TabIndex = 18;
            button3.Text = "testLeilaoDB";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.PaleTurquoise;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Location = new Point(78, 229);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(1315, 757);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // Home_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(1493, 1003);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(ordenar_combo);
            Controls.Add(txtBox_pesquisar);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(perfil_button);
            Controls.Add(logout_button);
            Controls.Add(btn_vender);
            Controls.Add(ajuda_button);
            Controls.Add(btn_leiloes);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Home_Form";
            Text = "Form1";
            Load += Home_Form_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_leiloes;
        private Button ajuda_button;
        private Button btn_vender;
        private Button logout_button;
        private Button perfil_button;
        private Button button6;
        private Label label1;
        private Button pesquisar_button;
        private TextBox txtBox_pesquisar;
        private ComboBox ordenar_combo;
        private ComboBox comboBox2;
        private Button button1;
        private Panel panel1;
        private Panel panel2;
        private Button button2;
        private Button button3;
        private TableLayoutPanel tableLayoutPanel1;
        private Button prevPage_button;
        private Button nextPage_button;
    }
}