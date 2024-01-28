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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_Form));
            btn_leiloes = new Button();
            ajuda_button = new Button();
            btn_vender = new Button();
            logout_button = new Button();
            perfil_button = new Button();
            editcl_button = new Button();
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
            editvin_button = new Button();
            editlei_button = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btn_leiloes
            // 
            btn_leiloes.BackColor = Color.PaleTurquoise;
            btn_leiloes.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_leiloes.ForeColor = SystemColors.ButtonHighlight;
            btn_leiloes.Location = new Point(284, 80);
            btn_leiloes.Name = "btn_leiloes";
            btn_leiloes.Size = new Size(228, 50);
            btn_leiloes.TabIndex = 0;
            btn_leiloes.Text = "Leilões";
            btn_leiloes.UseVisualStyleBackColor = false;
            btn_leiloes.Click += button1_Click;
            // 
            // ajuda_button
            // 
            ajuda_button.BackColor = Color.PaleTurquoise;
            ajuda_button.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ajuda_button.ForeColor = SystemColors.ButtonHighlight;
            ajuda_button.Location = new Point(520, 80);
            ajuda_button.Name = "ajuda_button";
            ajuda_button.Size = new Size(228, 50);
            ajuda_button.TabIndex = 1;
            ajuda_button.Text = "Ajuda";
            ajuda_button.UseVisualStyleBackColor = false;
            ajuda_button.Click += button2_Click;
            // 
            // btn_vender
            // 
            btn_vender.BackColor = Color.PaleTurquoise;
            btn_vender.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_vender.ForeColor = SystemColors.ControlLightLight;
            btn_vender.Location = new Point(753, 80);
            btn_vender.Name = "btn_vender";
            btn_vender.Size = new Size(228, 50);
            btn_vender.TabIndex = 2;
            btn_vender.Text = "Criar leilão";
            btn_vender.UseVisualStyleBackColor = false;
            btn_vender.Click += btn_vender_Click;
            // 
            // logout_button
            // 
            logout_button.Location = new Point(1058, 35);
            logout_button.Name = "logout_button";
            logout_button.Size = new Size(115, 50);
            logout_button.TabIndex = 3;
            logout_button.Text = "Login";
            logout_button.UseVisualStyleBackColor = true;
            logout_button.Click += button4_Click;
            // 
            // perfil_button
            // 
            perfil_button.Location = new Point(1179, 35);
            perfil_button.Name = "perfil_button";
            perfil_button.Size = new Size(58, 50);
            perfil_button.TabIndex = 4;
            perfil_button.Text = "Perfil";
            perfil_button.UseVisualStyleBackColor = true;
            perfil_button.Click += button5_Click;
            // 
            // editcl_button
            // 
            editcl_button.Location = new Point(1264, 92);
            editcl_button.Name = "editcl_button";
            editcl_button.Size = new Size(80, 40);
            editcl_button.TabIndex = 5;
            editcl_button.Text = "Editar Clientes";
            editcl_button.UseVisualStyleBackColor = true;
            editcl_button.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 45F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Turquoise;
            label1.Location = new Point(528, 2);
            label1.Name = "label1";
            label1.Size = new Size(343, 81);
            label1.TabIndex = 7;
            label1.Text = "Spin to Win";
            label1.Click += label1_Click;
            // 
            // pesquisar_button
            // 
            pesquisar_button.Location = new Point(3, 2);
            pesquisar_button.Name = "pesquisar_button";
            pesquisar_button.Size = new Size(75, 23);
            pesquisar_button.TabIndex = 10;
            pesquisar_button.Text = "pesquisar";
            pesquisar_button.UseVisualStyleBackColor = true;
            pesquisar_button.Click += pesquisar_button_Click;
            // 
            // txtBox_pesquisar
            // 
            txtBox_pesquisar.Location = new Point(159, 144);
            txtBox_pesquisar.Name = "txtBox_pesquisar";
            txtBox_pesquisar.PlaceholderText = "Pesquisar leilão...";
            txtBox_pesquisar.Size = new Size(354, 23);
            txtBox_pesquisar.TabIndex = 11;
            // 
            // ordenar_combo
            // 
            ordenar_combo.FormattingEnabled = true;
            ordenar_combo.Items.AddRange(new object[] { "Preço (Asc.)", "Preço (Des.)", "Nº Vinis (Asc.)", "Nº Vinis (Des.)", "Tempo restante (Asc.)", "Tempo restante (Des.)" });
            ordenar_combo.Location = new Point(540, 143);
            ordenar_combo.Name = "ordenar_combo";
            ordenar_combo.Size = new Size(121, 23);
            ordenar_combo.TabIndex = 12;
            ordenar_combo.Text = "Ordenar por";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(667, 143);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 13;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(1264, 6);
            button1.Name = "button1";
            button1.Size = new Size(30, 23);
            button1.TabIndex = 14;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(pesquisar_button);
            panel1.Location = new Point(68, 141);
            panel1.Name = "panel1";
            panel1.Size = new Size(1182, 100);
            panel1.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCyan;
            panel2.Controls.Add(prevPage_button);
            panel2.Controls.Add(nextPage_button);
            panel2.Location = new Point(1216, 141);
            panel2.Name = "panel2";
            panel2.Size = new Size(52, 807);
            panel2.TabIndex = 16;
            // 
            // prevPage_button
            // 
            prevPage_button.Location = new Point(9, 340);
            prevPage_button.Name = "prevPage_button";
            prevPage_button.Size = new Size(34, 23);
            prevPage_button.TabIndex = 21;
            prevPage_button.Text = "<";
            prevPage_button.UseVisualStyleBackColor = true;
            prevPage_button.Click += prevPage_button_Click_1;
            // 
            // nextPage_button
            // 
            nextPage_button.Location = new Point(9, 269);
            nextPage_button.Name = "nextPage_button";
            nextPage_button.Size = new Size(34, 23);
            nextPage_button.TabIndex = 20;
            nextPage_button.Text = ">";
            nextPage_button.UseVisualStyleBackColor = true;
            nextPage_button.Click += nextPage_button_Click;
            // 
            // editvin_button
            // 
            editvin_button.Location = new Point(1178, 92);
            editvin_button.Name = "editvin_button";
            editvin_button.Size = new Size(80, 38);
            editvin_button.TabIndex = 17;
            editvin_button.Text = "Editar Vinis";
            editvin_button.UseVisualStyleBackColor = true;
            editvin_button.Click += button2_Click_1;
            // 
            // editlei_button
            // 
            editlei_button.Location = new Point(1063, 91);
            editlei_button.Name = "editlei_button";
            editlei_button.Size = new Size(109, 40);
            editlei_button.TabIndex = 18;
            editlei_button.Text = "Editar Leilões";
            editlei_button.UseVisualStyleBackColor = true;
            editlei_button.Click += button3_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.PaleTurquoise;
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Location = new Point(68, 172);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(1151, 776);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(10, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(261, 124);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // Home_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1600, 1000);
            Controls.Add(pictureBox2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(editlei_button);
            Controls.Add(editvin_button);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(ordenar_combo);
            Controls.Add(txtBox_pesquisar);
            Controls.Add(label1);
            Controls.Add(editcl_button);
            Controls.Add(perfil_button);
            Controls.Add(logout_button);
            Controls.Add(btn_vender);
            Controls.Add(ajuda_button);
            Controls.Add(btn_leiloes);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home_Form";
            Text = "Form1";
            Load += Home_Form_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_leiloes;
        private Button ajuda_button;
        private Button btn_vender;
        private Button logout_button;
        private Button perfil_button;
        private Button editcl_button;
        private Label label1;
        private Button pesquisar_button;
        private TextBox txtBox_pesquisar;
        private ComboBox ordenar_combo;
        private ComboBox comboBox2;
        private Button button1;
        private Panel panel1;
        private Panel panel2;
        private Button editvin_button;
        private Button editlei_button;
        private TableLayoutPanel tableLayoutPanel1;
        private Button prevPage_button;
        private Button nextPage_button;
        private PictureBox pictureBox2;
    }
}