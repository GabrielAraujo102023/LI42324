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
    public partial class Perfil_Form : Form
    {
        public Perfil_Form()
        {
            ClientDAO clienteDAO = new ClientDAO();
            LeilaoDAO leilaoDAO = new LeilaoDAO();
            VinilDAO vinilDAO = new VinilDAO();
            InitializeComponent();
            Client cliente = clienteDAO.GetClientbyID(Global.accountID);
            List<Leilao> leiloesVendidos = leilaoDAO.GetLeilaoByVendedor(Global.accountID);
            leiloesVendidos.RemoveAll(x => x.Comprador == null);
            List<Leilao> leiloesComprados = leilaoDAO.GetLeilaoByComprador(Global.accountID);
            accountName_label.Text = cliente.Email.Substring(0, cliente.Email.IndexOf('@'));
            saldo_label.Text += cliente.Dinheiro.ToString();
            leiloesComprados_label.Text += leiloesComprados.Count.ToString();
            leiloesVendidos_label.Text += leiloesVendidos.Count.ToString();
            float totalGasto = 0, totalGanho = 0;
            Dictionary<string, int> generosComprados = new Dictionary<string, int>();
            Dictionary<string, int> generosVendidos = new Dictionary<string, int>();
            if (leiloesVendidos.Count != 0)
            {
                foreach (Leilao l in leiloesVendidos)
                {
                    totalGanho += l.PrecoVenda;
                    List<Vinil> vinis = vinilDAO.GetVinisByLeilao((int)l.IdLeilao);
                    foreach (Vinil v in vinis)
                    {
                        if (generosVendidos.ContainsKey(v.Categoria))
                            generosVendidos[v.Categoria] += 1;
                        else
                            generosVendidos.Add(v.Categoria, 1);
                    }
                }
                int maxValue = generosVendidos.Max(kv => kv.Value);
                List<string> keysWithMaxValue = generosVendidos
                    .Where(kv => kv.Value == maxValue)
                    .Select(kv => kv.Key)
                    .ToList();
                generoVendido_label.Text = generoVendido_label.Text + string.Join(", ", keysWithMaxValue);
            }
            else
            {
                generoVendido_label.Text += "N/A";
            }
            if (leiloesComprados.Count != 0)
            {
                foreach (Leilao l in leiloesComprados)
                {
                    totalGasto += l.PrecoVenda;
                    List<Vinil> vinis = vinilDAO.GetVinisByLeilao((int)l.IdLeilao);
                    foreach (Vinil v in vinis)
                    {
                        if (generosComprados.ContainsKey(v.Categoria))
                            generosComprados[v.Categoria] += 1;
                        else
                            generosComprados.Add(v.Categoria, 1);
                    }
                }
                int maxValue = generosComprados.Max(kv => kv.Value);
                List<string> keysWithMaxValue = generosComprados
                    .Where(kv => kv.Value == maxValue)
                    .Select(kv => kv.Key)
                    .ToList();
                generoComprado_label.Text = generoComprado_label.Text + string.Join(", ", keysWithMaxValue);
            }
            else
            {
                generoComprado_label.Text += "N/A";
            }

            totalGanho_label.Text += totalGanho.ToString();
            totalGasto_label.Text += totalGasto.ToString();
            lucro_label.Text += (totalGanho - totalGasto).ToString();
        }

        private void adicionarSaldo_button_Click(object sender, EventArgs e)
        {
            new adicionarSaldo_Form().Show();
            Close();
        }

        private void Voltar_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void levantar_button_Click(object sender, EventArgs e)
        {
            new levantarSaldo_Form().Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Vinil_Form().Show();
            Close();
        }
    }
}
