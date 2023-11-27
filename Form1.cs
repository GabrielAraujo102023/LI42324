namespace SpinToWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //É para aqui que carregamos os leiloes
            for (int i = 0; i < 500; i++)
            {
                Button btn = new Button();
                btn.Text = "TEST";
                btn.Height = 35;

                this.flowLayoutPanel1.Controls.Add(btn);
            }

            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Scroll += FlowLayoutPanel1_Scroll;
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

        private void FlowLayoutPanel1_Scroll(object sender, ScrollEventArgs e)
        {
            MessageBox.Show("Event Triggered");
        }
    }
}