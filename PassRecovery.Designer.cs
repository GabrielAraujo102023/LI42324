namespace SpinToWin
{
    partial class PassRecovery:Form
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
            recover = new Button();
            cancel = new Button();
            msgtexto = new Label();
            codverification = new TextBox();
            verify = new Button();
            SuspendLayout();
            // 
            // recover
            // 
            recover.Location = new Point(32, 77);
            recover.Name = "recover";
            recover.Size = new Size(137, 23);
            recover.TabIndex = 0;
            recover.Text = "Reset Password";
            recover.UseVisualStyleBackColor = true;
            recover.Click += recover_Click;
            // 
            // cancel
            // 
            cancel.Location = new Point(421, 77);
            cancel.Name = "cancel";
            cancel.Size = new Size(75, 23);
            cancel.TabIndex = 1;
            cancel.Text = "Cancelar";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // msgtexto
            // 
            msgtexto.Anchor = AnchorStyles.None;
            msgtexto.AutoSize = true;
            msgtexto.Location = new Point(244, 30);
            msgtexto.Name = "msgtexto";
            msgtexto.Size = new Size(38, 15);
            msgtexto.TabIndex = 2;
            msgtexto.Text = "label1";
            // 
            // codverification
            // 
            codverification.Location = new Point(153, 30);
            codverification.Name = "codverification";
            codverification.Size = new Size(233, 23);
            codverification.TabIndex = 3;
            codverification.Text = "Insira aqui o seu código de verificação";
            codverification.TextAlign = HorizontalAlignment.Center;
            codverification.Click += resetbox;
            codverification.Hide();
            // 
            // verify
            // 
            verify.Location = new Point(228, 81);
            verify.Name = "verify";
            verify.Size = new Size(75, 23);
            verify.TabIndex = 4;
            verify.Text = "Confirmar";
            verify.UseVisualStyleBackColor = true;
            verify.Click += verify_Click_1;
            verify.Hide();
            // 
            // PassRecovery
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 123);
            Controls.Add(verify);
            Controls.Add(codverification);
            Controls.Add(msgtexto);
            Controls.Add(cancel);
            Controls.Add(recover);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "PassRecovery";
            Text = "PassRecovery";
            Load += PassRecovery_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        public void resetbox(object sender, EventArgs e)
        {
            codverification.Text = "";
        }

        public PassRecovery(string message,string email)
        {
            InitializeComponent();
            setEmail(email);
            InitializeGmailService();
            msgtexto.Text = message;
        }

        private void PassRecovery_Load(object sender, EventArgs e)
        {
            int centerX = (this.ClientSize.Width - msgtexto.Width) / 2;
            msgtexto.Location = new Point(centerX, 29);
        }

        #endregion

        private Button recover;
        private Button cancel;
        private Label msgtexto;
        private TextBox codverification;
        private Button verify;
    }
}