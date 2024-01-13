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
    public partial class FormTests : Form
    {
        private const string PlaceholderTextEmail = "Email";
        private const string PlaceholderTextPassword = "Password";
        private const string PlaceholderTextDinheiro = "Dinheiro";
        private string userInput;
        BindingSource clientBinding = new BindingSource();
        ClientDAO clientDAO = new ClientDAO();


        public FormTests()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            // Set the placeholder text initially
            SetPlaceholder();

            // Attach the Enter and Leave event handlers
            textBox1.Enter += TextBox1_Enter;
            textBox1.Leave += TextBox1_Leave;
            textBox2.Enter += TextBox2_Enter;
            textBox2.Leave += TextBox2_Leave;
            textBox3.Enter += TextBox3_Enter;
            textBox3.Leave += TextBox3_Leave;

        }
        private void SetPlaceholder()
        {
            // Set the placeholder text with a different color
            textBox1.ForeColor = SystemColors.GrayText;
            textBox1.Text = "Email";
            textBox2.ForeColor = SystemColors.GrayText;
            textBox2.Text = "Password";
            textBox3.ForeColor = SystemColors.GrayText;
            textBox3.Text = "Dinheiro";
        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            // Clear the placeholder text when the textbox gets focus
            if (textBox1.Text == PlaceholderTextEmail)
            {
                textBox1.Text = string.Empty;
                textBox1.ForeColor = SystemColors.WindowText; // Set the text color back to default
            }
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            // Set the placeholder text back if no input was provided
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                SetPlaceholder();
            }
        }
        private void TextBox2_Enter(object sender, EventArgs e)
        {
            // Clear the placeholder text when the textbox gets focus
            if (textBox2.Text == PlaceholderTextPassword)
            {
                textBox2.Text = string.Empty;
                textBox2.ForeColor = SystemColors.WindowText; // Set the text color back to default
            }
        }

        private void TextBox2_Leave(object sender, EventArgs e)
        {
            // Set the placeholder text back if no input was provided
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                SetPlaceholder();
            }
        }

        private void TextBox3_Enter(object sender, EventArgs e)
        {
            // Clear the placeholder text when the textbox gets focus
            if (textBox3.Text == PlaceholderTextDinheiro)
            {
                textBox3.Text = string.Empty;
                textBox3.ForeColor = SystemColors.WindowText; // Set the text color back to default
            }
        }

        private void TextBox3_Leave(object sender, EventArgs e)
        {
            // Set the placeholder text back if no input was provided
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                SetPlaceholder();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            clientBinding.DataSource = clientDAO.GetListClients();
            dataGridView1.DataSource = clientBinding;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string pass = textBox2.Text;
            double dinheiro = Convert.ToDouble(textBox3.Text);
            Client clienttmp = new Client(email, pass, dinheiro);
            int idcliente = clientDAO.InsertClient(clienttmp);
            Client client = new Client(idcliente, email, pass, dinheiro);
            MessageBox.Show(client.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string pass = textBox2.Text;
            double dinheiro = Convert.ToDouble(textBox3.Text);
            Client client = new Client(email, pass, dinheiro);
            clientDAO.UpdateClient(client);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //botão texto
            string userInput = textBox1.Text;
            MessageBox.Show(userInput);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string email = textBox4.Text;
            clientDAO.DeleteClient(email);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string email = textBox5.Text;
            Client client = clientDAO.GetClientByEmail(email);
            MessageBox.Show(client.ToString());
        }
    }
}
