namespace SpinToWin
{
    partial class CriarLeilao_Form
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
            button1 = new Button();
            label1 = new Label();
            button5 = new Button();
            logout_button = new Button();
            btn_vender = new Button();
            btn_comprar = new Button();
            btn_leiloes = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            pesquisar_textBox = new TextBox();
            pesquisar_button = new Button();
            nextPage_button = new Button();
            prevPage_button = new Button();
            label2 = new Label();
            valorMinimo_textBox = new TextBox();
            valorBase_textBox = new TextBox();
            label3 = new Label();
            criar_button = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(1252, 5);
            button1.Name = "button1";
            button1.Size = new Size(30, 23);
            button1.TabIndex = 26;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 34);
            label1.Name = "label1";
            label1.Size = new Size(230, 54);
            label1.TabIndex = 25;
            label1.Text = "Spin to Win";
            // 
            // button5
            // 
            button5.Location = new Point(1167, 34);
            button5.Name = "button5";
            button5.Size = new Size(58, 50);
            button5.TabIndex = 23;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // logout_button
            // 
            logout_button.Location = new Point(1046, 34);
            logout_button.Name = "logout_button";
            logout_button.Size = new Size(115, 50);
            logout_button.TabIndex = 22;
            logout_button.Text = "Login";
            logout_button.UseVisualStyleBackColor = true;
            logout_button.Click += logout_button_Click;
            // 
            // btn_vender
            // 
            btn_vender.Location = new Point(741, 34);
            btn_vender.Name = "btn_vender";
            btn_vender.Size = new Size(228, 50);
            btn_vender.TabIndex = 21;
            btn_vender.Text = "Criar Leilão";
            btn_vender.UseVisualStyleBackColor = true;
            // 
            // btn_comprar
            // 
            btn_comprar.Location = new Point(507, 34);
            btn_comprar.Name = "btn_comprar";
            btn_comprar.Size = new Size(228, 50);
            btn_comprar.TabIndex = 20;
            btn_comprar.Text = "Comprar";
            btn_comprar.UseVisualStyleBackColor = true;
            // 
            // btn_leiloes
            // 
            btn_leiloes.Location = new Point(273, 34);
            btn_leiloes.Name = "btn_leiloes";
            btn_leiloes.Size = new Size(228, 50);
            btn_leiloes.TabIndex = 19;
            btn_leiloes.Text = "Leilões";
            btn_leiloes.UseVisualStyleBackColor = true;
            btn_leiloes.Click += btn_leiloes_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 96.80751F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.19248819F));
            tableLayoutPanel1.Location = new Point(17, 165);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(1065, 413);
            tableLayoutPanel1.TabIndex = 27;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // pesquisar_textBox
            // 
            pesquisar_textBox.Location = new Point(103, 136);
            pesquisar_textBox.Name = "pesquisar_textBox";
            pesquisar_textBox.Size = new Size(398, 23);
            pesquisar_textBox.TabIndex = 28;
            // 
            // pesquisar_button
            // 
            pesquisar_button.Location = new Point(22, 136);
            pesquisar_button.Name = "pesquisar_button";
            pesquisar_button.Size = new Size(75, 23);
            pesquisar_button.TabIndex = 29;
            pesquisar_button.Text = "pesquisar";
            pesquisar_button.UseVisualStyleBackColor = true;
            pesquisar_button.Click += pesquisar_button_Click;
            // 
            // nextPage_button
            // 
            nextPage_button.Location = new Point(1088, 319);
            nextPage_button.Name = "nextPage_button";
            nextPage_button.Size = new Size(31, 23);
            nextPage_button.TabIndex = 30;
            nextPage_button.Text = ">";
            nextPage_button.UseVisualStyleBackColor = true;
            // 
            // prevPage_button
            // 
            prevPage_button.Location = new Point(1088, 359);
            prevPage_button.Name = "prevPage_button";
            prevPage_button.Size = new Size(31, 23);
            prevPage_button.TabIndex = 31;
            prevPage_button.Text = "<";
            prevPage_button.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(17, 595);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 32;
            label2.Text = "Valor Base:";
            // 
            // valorMinimo_textBox
            // 
            valorMinimo_textBox.Location = new Point(161, 623);
            valorMinimo_textBox.Name = "valorMinimo_textBox";
            valorMinimo_textBox.Size = new Size(134, 23);
            valorMinimo_textBox.TabIndex = 33;
            // 
            // valorBase_textBox
            // 
            valorBase_textBox.Location = new Point(21, 623);
            valorBase_textBox.Name = "valorBase_textBox";
            valorBase_textBox.Size = new Size(100, 23);
            valorBase_textBox.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(161, 595);
            label3.Name = "label3";
            label3.Size = new Size(130, 25);
            label3.TabIndex = 35;
            label3.Text = "Valor Mínimo:";
            // 
            // criar_button
            // 
            criar_button.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            criar_button.Location = new Point(858, 584);
            criar_button.Name = "criar_button";
            criar_button.Size = new Size(215, 88);
            criar_button.TabIndex = 36;
            criar_button.Text = "Criar";
            criar_button.UseVisualStyleBackColor = true;
            criar_button.Click += criar_button_Click;
            // 
            // CriarLeilao_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1290, 684);
            Controls.Add(criar_button);
            Controls.Add(label3);
            Controls.Add(valorBase_textBox);
            Controls.Add(valorMinimo_textBox);
            Controls.Add(label2);
            Controls.Add(prevPage_button);
            Controls.Add(nextPage_button);
            Controls.Add(pesquisar_button);
            Controls.Add(pesquisar_textBox);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(logout_button);
            Controls.Add(btn_vender);
            Controls.Add(btn_comprar);
            Controls.Add(btn_leiloes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CriarLeilao_Form";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label1;
        private Button button5;
        private Button logout_button;
        private Button btn_vender;
        private Button btn_comprar;
        private Button btn_leiloes;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox pesquisar_textBox;
        private Button pesquisar_button;
        private Button nextPage_button;
        private Button prevPage_button;
        private Label label2;
        private TextBox valorMinimo_textBox;
        private TextBox valorBase_textBox;
        private Label label3;
        private Button criar_button;
    }
}