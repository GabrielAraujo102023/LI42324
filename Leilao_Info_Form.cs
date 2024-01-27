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
    public partial class Leilao_Info_Form : Form
    {
        private Leilao leilao;

        public Leilao_Info_Form(Leilao leilao)
        {
            InitializeComponent();
            this.leilao = leilao;
            // Você pode usar 'this.leilao' para preencher os campos do formulário
        }

        private void Leilao_Info_Form_Load(object sender, EventArgs e)
        {
            label2.Text = $"ID: {leilao.IdLeilao}\n" +
                                   $"Estado: {leilao.Estado}\n" +
                                   $"Comprador: {leilao.Comprador}\n" +
                                   $"Valor Base: {leilao.ValorBase}\n" +
                                   $"Valor Mínimo: {leilao.ValorMinimo}\n" +
                                   $"Preço de Venda: {leilao.PrecoVenda}\n" +
                                   $"Vendedor: {leilao.Vendedor}";
        }

    }
}
