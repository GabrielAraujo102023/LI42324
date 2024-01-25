using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpinToWin
{
    public partial class adicionarSaldo_Form : Form
    {
        private bool cartao;
        private bool gerado = false;
        public adicionarSaldo_Form()
        {
            InitializeComponent();
        }

        private void sair_button_Click(object sender, EventArgs e)
        {
            new Perfil_Form().Show();
            Close();
        }

        private void cartao_button_Click(object sender, EventArgs e)
        {
            cartao_button.Visible = false;
            transferencia_button.Visible = false;

            numeroCartao_label.Visible = true;
            numeroCartao_textBox.Visible = true;
            dataValidade_label.Visible = true;
            dataValidade_textBox.Visible = true;
            cvc_label.Visible = true;
            cvc_textBox.Visible = true;
            valor_label.Visible = true;
            valor_textBox.Visible = true;
            concluir_button.Visible = true;
            cartao = true;
        }

        private void concluir_button_Click(object sender, EventArgs e)
        {
            if (cartao)
                concluir_cartao();
            else
                concluir_transferencia();
        }

        private void concluir_cartao()
        {
            if (numeroCartao_textBox.Text == "" || !numeroCartao_textBox.Text.All(Char.IsDigit) || numeroCartao_textBox.Text.Length != 16)
            {
                MessageBox.Show("Insira um número de cartão válido.");
            }
            else if (dataValidade_textBox.Text == "" || !Regex.IsMatch(dataValidade_textBox.Text, @"^(0[1-9]|1[0-2])/(0[1-9]|[1-9][0-9])$"))
            {
                MessageBox.Show("Insira uma data de validade válida.");
            }
            else if (cvc_textBox.Text == "" || cvc_textBox.Text.Length != 3 || !cvc_textBox.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Insira um CVC válido.");
            }
            else if (valor_textBox.Text == "" || !valor_textBox.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Insira um valor válido.");
            }
            else
            {
                MessageBox.Show("Dados validados com sucesso.");
                try
                {
                    ClientDAO clientDAO = new ClientDAO();
                    Client thisClient = clientDAO.GetClientbyID(Global.accountID);
                    thisClient.Dinheiro += double.Parse(valor_textBox.Text);
                    clientDAO.UpdateClientByID(Global.accountID, thisClient);
                    MessageBox.Show("Montante adicionado com sucesso!");
                }
                finally
                {
                    new Perfil_Form().Show();
                    Close();
                }
            }
        }

        private void transferencia_button_Click(object sender, EventArgs e)
        {
            cartao_button.Visible = false;
            transferencia_button.Visible = false;

            entidade_label.Visible = true;
            referencia_label.Visible = true;
            valor_label.Visible = true;
            valor_textBox.Visible = true;
            dataLimite_label.Visible = true;
            concluir_button.Visible = true;
            concluir_button.Text = "Gerar";
            cartao = false;
        }

        private void concluir_transferencia()
        {
            if (valor_textBox.Text == "" || !valor_textBox.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Insira um valor válido.");
            }
            else if (!gerado)
            {
                entidade_label.Text += "12345";
                referencia_label.Text += new Random().Next(100000000, 1000000000).ToString();
                dataLimite_label.Text += DateTime.Now.AddDays(15).ToShortDateString();
                gerado = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
