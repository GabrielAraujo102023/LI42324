using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SpinToWin
{
    public partial class Login_Form : Form
    {
        private Form home_form;
        private ClientDAO clientDAO = new ClientDAO();
        public Login_Form(Form home_form)
        {
            InitializeComponent();
            this.home_form = home_form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (areTextBoxesEmpty()) return;
            Client client = clientDAO.GetClientByEmail(textBox1.Text);
            if (client == null || PasswordHasher.VerifyPassword(client.Pass, PasswordHasher.HashPassword(textBox2.Text)))
            Console.WriteLine("User que fez login : " + client.Email);
            Console.WriteLine("Pass que fez login : " + client.Pass);
            Console.WriteLine("Pass introduzida : " + textBox2.Text);
            if (client == null || !PasswordHasher.VerifyPassword(textBox2.Text, client.Pass))
            {
                PassRecovery passRecoveryForm = new PassRecovery("Credenciais não válidas! Deseja Receber um Email para fazer Reset á sua Password?", textBox1.Text);
                passRecoveryForm.Show();

            }
            else
            {
                Console.WriteLine("Username" + client.Email);
                Console.WriteLine("Pass na BD" + client.Pass);
                Console.WriteLine("Pass no login" + PasswordHasher.HashPassword(textBox2.Text));
                Global.accountID = client.Email.Equals("admin") ? 0 : (int)client.Id;
                showHomeForm(true);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showHomeForm(false);
        }

        public void showHomeForm(bool loggedIn)
        {
            Global.isLoggedIn = loggedIn;
            home_form.Refresh();
            home_form.Show();
            Close();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void registar_button_Click(object sender, EventArgs e)
        {
            if (areTextBoxesEmpty()) return;
            Client client = clientDAO.GetClientByEmail(textBox1.Text);
            if (client != null)
            {
                MessageBox.Show("Já existe um registo com esse email.");
                return;
            }
            if (!textBox1.Text.Contains('@'))
            {
                MessageBox.Show("O email inserido não é válido.");
                return;
            }
            string pass = PasswordHasher.HashPassword(textBox2.Text);
            clientDAO.InsertClient(new Client(textBox1.Text, pass, 0));
            Console.WriteLine("Pass no registo: " + pass);
            MessageBox.Show("Registo efetuado com sucesso.");
        }

        private bool areTextBoxesEmpty()
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Preencha os campos todos.");
                return true;
            }
            return false;
        }

        private void Login_Form_Load_1(object sender, EventArgs e)
        {

        }
    }
}
