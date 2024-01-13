namespace SpinToWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            flowLayoutPanel1.VerticalScroll.Visible = false;
            //É para aqui que carregamos os leiloes
            for (int i = 0; i < 500; i++)
            {
                Button btn = new Button();
                btn.Text = "TEST";
                btn.Height = 35;

                this.flowLayoutPanel1.Controls.Add(btn);
            }

            this.flowLayoutPanel1.AutoScroll = true;
            //this.flowLayoutPanel1.Scroll += FlowLayoutPanel1_Scroll;;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load() { }

        public override void Refresh()
        {
            if (Global.isLoggedIn)
            {
                logout_button.Text = "Logout";
            }
            else
            {
                logout_button.Text = "Login";
            }
            base.Refresh();
        }

        // BOTÃO DE LOGOUT
        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Global.isLoggedIn = false;
            Login_Form login_Form = new Login_Form(this);
            login_Form.Show();
        }

        // BOTÃO DE SAIR
        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            FormTests formTests = new FormTests();
            formTests.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Hide();
            VinilTests vinilTests = new VinilTests();
            vinilTests.Show();
        }
    }
}