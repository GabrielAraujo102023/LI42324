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
        }
        private void SetPlaceholder()
        {
            // Set the placeholder text with a different color
            textBox1.ForeColor = SystemColors.GrayText;
            textBox1.Text = PlaceholderTextEmail;
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
            Client client = new Client("user", "321", 1212);
            clientDAO.InsertClient(client);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Client c = new Client("user", "321", 121212122);
            clientDAO.UpdateClient(c);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //botão texto
            string userInput = textBox1.Text;
            MessageBox.Show(userInput);
        }
    }
}
