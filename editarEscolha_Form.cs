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
    public partial class editarEscolha_Form : Form
    {
        private char vinilOUleilao;
        public editarEscolha_Form(char vinilOUleilao)
        {
            InitializeComponent();
            this.vinilOUleilao = vinilOUleilao;
            if (vinilOUleilao == 'v')
            {
                editarVinis();
            }
            else if (vinilOUleilao == 'l')
            {
                editarLeiloes();
            }
        }

        private void editarVinis()
        {
            escolhaum_label.Text += "vinil:";
            BindingSource bind = new BindingSource();
            List<Vinil> vinis = new VinilDAO().GetVinisByCliente(Global.accountID);
            vinis.RemoveAll(v => v.Leilao != null);
            List<VinilInfo> info = new List<VinilInfo>();
            foreach (Vinil v in vinis)
            {
                info.Add(new VinilInfo(v));
            }
            bind.DataSource = info;
            dataGridView1.DataSource = bind;
        }

        private void editarLeiloes()
        {
            escolhaum_label.Text += "leilão:";
            BindingSource bind = new BindingSource();
            List<Leilao> leiloes = new LeilaoDAO().GetLeilaoByVendedor(Global.accountID);
            leiloes.RemoveAll(l => l.Estado != "catalogado");
            bind.DataSource = leiloes;
            dataGridView1.DataSource = bind;
            dataGridView1.Columns["Comprador"].Visible = false;
            dataGridView1.Columns["Vendedor"].Visible = false;
            dataGridView1.Columns["Estado"].Visible = false;
        }

        private void sair_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idString = vinilOUleilao == 'v' ? "idVinil" : "idLeilao";
            int id = 0;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows) 
            {
                id = (int)row.Cells[idString].Value;
                break;
            }
            if (id == 0)
                return;
            if (vinilOUleilao == 'v')
                new Vinil_Form(new VinilDAO().GetVinilById(id)).Show();
            Close();
        }
    }
}
