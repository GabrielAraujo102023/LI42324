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
    public partial class levantarSaldo_Form : Form
    {
        public levantarSaldo_Form()
        {
            InitializeComponent();
        }

        private void sair_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void levantar_button_Click(object sender, EventArgs e)
        {
            ClientDAO clientDAO = new ClientDAO();
            Client thisClient = clientDAO.GetClientbyID(Global.accountID);
            if(iban_textBox.Text == "")
            {
                MessageBox.Show("Insira um IBAN.");
            }
            else if (valor_textBox.Text == "" || !valor_textBox.Text.All(Char.IsDigit) || double.Parse(valor_textBox.Text) > thisClient.Dinheiro)
            {
                MessageBox.Show("Insira um valor válido.");
            }
            else
            {
                MessageBox.Show("Dados validados com sucesso.");
                try
                {  
                    thisClient.Dinheiro -= double.Parse(valor_textBox.Text);
                    clientDAO.UpdateClientByID(Global.accountID, thisClient);
                    MessageBox.Show("Montante levantado com sucesso!");
                }
                finally
                {
                    new Perfil_Form().Show();
                    Close();
                }
            }
        }
    }
}
