namespace SpinToWin
{
    partial class editarEscolha_Form
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
            escolhaum_label = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // sair_button
            // 
            sair_button.Location = new Point(759, 12);
            sair_button.Name = "sair_button";
            sair_button.Size = new Size(29, 23);
            sair_button.TabIndex = 0;
            sair_button.Text = "X";
            sair_button.UseVisualStyleBackColor = true;
            sair_button.Click += sair_button_Click;
            // 
            // escolhaum_label
            // 
            escolhaum_label.AutoSize = true;
            escolhaum_label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            escolhaum_label.Location = new Point(12, 33);
            escolhaum_label.Name = "escolhaum_label";
            escolhaum_label.Size = new Size(142, 32);
            escolhaum_label.TabIndex = 1;
            escolhaum_label.Text = "Escolha um ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 276);
            dataGridView1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(321, 377);
            button1.Name = "button1";
            button1.Size = new Size(129, 48);
            button1.TabIndex = 3;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // editarEscolha_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(escolhaum_label);
            Controls.Add(sair_button);
            FormBorderStyle = FormBorderStyle.None;
            Name = "editarEscolha_Form";
            Text = "editarEscolha_Form";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sair_button;
        private Label escolhaum_label;
        private DataGridView dataGridView1;
        private Button button1;
    }
}