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

        BindingSource clientBinding = new BindingSource();
        ClientDAO clientDAO = new ClientDAO();


        public FormTests()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clientBinding.DataSource = clientDAO.GetClients();
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
    }
}
