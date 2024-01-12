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

        public FormTests()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientDAO clientDAO = new ClientDAO();
            clientBinding.DataSource = clientDAO.GetClients();

            dataGridView1.DataSource = clientBinding;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
