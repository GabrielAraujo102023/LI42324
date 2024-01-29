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
    public partial class UserPasswordReset : Form
    {

        private static string email;

        public UserPasswordReset()
        {
            InitializeComponent();
        }

        public UserPasswordReset(string emailof)
        {
            InitializeComponent();
            email = emailof;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(textBox2.Text))
            {
                string pass = PasswordHasher.HashPassword(textBox1.Text);
                ClientDAO clientDAO = new ClientDAO();
                Client ant = clientDAO.GetClientByEmail(email);
                ant.Pass = pass;
                clientDAO.UpdateClient(ant);
                MessageBox.Show($"Password alterada com sucesso");
                this.Close();
            }
            else
            {
                MessageBox.Show($"As senhas digitadas não coincidem");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(textBox2.Text))
            {
                textBox2.BackColor = Color.Green;
                textBox1.BackColor = Color.Green;
            }
            else
            {
                textBox2.BackColor = Color.Red;
                textBox1.BackColor = Color.White;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.PasswordChar = '\0';
            }
            else
            {
                textBox1.PasswordChar = '*';
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }
    }
}
