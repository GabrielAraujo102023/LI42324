using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpinToWin
{
    public partial class CriarLeilao_Form : Form
    {
        Home_Form home_form;
        private static VinilDAO vinilDAO = new VinilDAO();
        private static List<Vinil> vinis = vinilDAO.GetVinisByCliente(Global.accountID);
        private static int nItems = 10;
        private int curPagina = 0;
        private int maxPaginas = vinis.Count() / nItems;
        private List<Vinil> selectedVinis = new List<Vinil>();
        public CriarLeilao_Form(Home_Form home_form)
        {
            InitializeComponent();
            carregarVinis();
            Refresh();
            this.home_form = home_form;
        }

        private void carregarVinis()
        {
            vinis.RemoveAll(v => v.Leilao != null);
            
            int start = 0 + (nItems * curPagina);
            int nGet = nItems;
            if (start + nItems >= vinis.Count())
            {
                nGet = vinis.Count() - start;
            }
            List<Vinil> vinisPagina = vinis.GetRange(start, nGet);
            tableLayoutPanel1.Controls.Clear();
            foreach (Vinil v in vinisPagina)
            {
                Label nome = new Label();
                nome.Size = new Size(400, 41);
                nome.Font = new Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                nome.Text = v.Artista + " - " + v.Album;

                Button btn = new Button();
                if (selectedVinis.Contains(v))
                    btn.Text = "✓";
                else
                    btn.Text = "+";
                btn.Size = new Size(28, 35);
                btn.Click += (sender, e) => AddVinil_Click(sender, e, v);
                tableLayoutPanel1.Controls.Add(nome);
                tableLayoutPanel1.Controls.Add(btn);

            }
        }

        private void AddVinil_Click(object sender, EventArgs e, Vinil vinil)
        {
            Button btn = (Button)sender;
            if (btn.Text == "+")
            {
                btn.Text = "✓";
                selectedVinis.Add(vinil);
            }
            else
            {
                btn.Text = "+";
                selectedVinis.Remove(vinil);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

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

        private void logout_button_Click(object sender, EventArgs e)
        {
            Global.isLoggedIn = false;
            Login_Form login_Form = new Login_Form(home_form);
            login_Form.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_leiloes_Click(object sender, EventArgs e)
        {
            home_form.Refresh();
            home_form.reloadLeiloes();
            home_form.Show();
            Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void criar_button_Click(object sender, EventArgs e)
        {
            if (selectedVinis.Count == 0 || selectedVinis.Count > 50)
            {
                MessageBox.Show("Selecione pelo menos 1 viníl e no máximo 50");
            }
            else if (valorBase_textBox.Text == "" || !valorBase_textBox.Text.All(char.IsDigit))
            {
                MessageBox.Show("Insira um valor base válido.");
            }
            else if (valorMinimo_textBox.Text == "" || !valorMinimo_textBox.Text.All(char.IsDigit))
            {
                MessageBox.Show("Insira um valor mínimo válido.");
            }
            else
            {
                int valorBase = int.Parse(valorBase_textBox.Text);
                int valorMinimo = int.Parse(valorMinimo_textBox.Text);
                if (valorMinimo >= valorBase)
                {
                    MessageBox.Show("O valor mínimo não pode ser maior ou igual ao valor base.");
                }
                else
                {
                    //public Leilao(string estado, int? comprador, float valorBase, float valorMinimo, float? precoVenda, int vendedor)
                    Leilao leilao = new Leilao("catalogado", null, valorBase, valorMinimo, valorBase, Global.accountID);
                    int id = new LeilaoDAO().InsertLeilao(leilao);
                    if (id != -1)
                    {
                        foreach (Vinil v in selectedVinis)
                        {
                            vinilDAO.UpdateVinil((int)v.IdVinil, v.ChangeLeilao(id));
                        }
                        MessageBox.Show("Leilão criado com sucesso!");
                    }
                    else
                        MessageBox.Show("Ocorreu um erro a criar o seu leilão. Por favor, tente denovo mais tarde.");
                }
            }

        }

        private void pesquisar_button_Click(object sender, EventArgs e)
        {
            vinis = !pesquisar_textBox.Text.IsNullOrEmpty() ? vinilDAO.GetVinisByCliente(Global.accountID).FindAll(matchesSearch) : vinilDAO.GetVinisByCliente(Global.accountID);
            curPagina = 0;
            carregarVinis();
        }

        private bool matchesSearch(Vinil v)
        {
            string text = pesquisar_textBox.Text.ToLower();
            return v.Album.ToLower().Contains(text) || v.Artista.ToLower().Contains(text);
        }
    }
}
