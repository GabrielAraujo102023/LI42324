using Microsoft.Identity.Client.NativeInterop;
using Microsoft.IdentityModel.Tokens;

namespace SpinToWin
{
    public partial class Home_Form : Form
    {
        private static LeilaoDAO leilaoDAO = new LeilaoDAO();
        private static VinilDAO vinilDAO = new VinilDAO();
        private static List<Leilao> leiloes = leilaoDAO.GetListLeiloes();
        private static int nItems = 12;
        private int curPagina = 0;
        private int maxPaginas = leiloes.Count() / nItems;
        public Home_Form()
        {
            InitializeComponent();
            carregarLeiloes();
        }

        private void carregarLeiloes()
        {
            int start = 0 + (nItems * curPagina);
            int nGet = nItems;
            if (start + nItems >= leiloes.Count())
            {
                nGet = leiloes.Count() - start;
            }
            List<Leilao> leiloesPagina = leiloes.GetRange(start, nGet);
            tableLayoutPanel1.Controls.Clear();
            foreach (Leilao l in leiloesPagina)
            {
                //TODO: ADICIONAR IMAGENS
                FlowLayoutPanel p = new FlowLayoutPanel();
                Label estado = new Label();
                estado.Text = l.Estado;
                p.Controls.Add(estado);
                tableLayoutPanel1.Controls.Add(p);
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            LeilaoTests leilaoTests = new LeilaoTests();
            leilaoTests.Show();
        }

        private void nextPage_button_Click(object sender, EventArgs e)
        {
            if (curPagina < maxPaginas)
            {
                curPagina++;
                carregarLeiloes();
            }
        }

        private void prevPage_button_Click(object sender, EventArgs e)
        {
            if (curPagina > 0)
            {
                curPagina--;
                carregarLeiloes();
            }
        }

        private void pesquisar_button_Click(object sender, EventArgs e)
        {
            leiloes = !txtBox_pesquisar.Text.IsNullOrEmpty() ? leilaoDAO.GetListLeiloes().FindAll(matchesSearch) : leilaoDAO.GetListLeiloes();
            curPagina = 0;
            carregarLeiloes();
        }

        private bool matchesSearch(Leilao l)
        {
            List<Vinil> vinis = vinilDAO.GetVinisByLeilao((int)l.IdLeilao);
            foreach(Vinil v in vinis)
            {
                if (v.Album.Contains(txtBox_pesquisar.Text) || v.Artista.Contains(txtBox_pesquisar.Text))
                    return true;
            }
            return false;
        }
    }
}