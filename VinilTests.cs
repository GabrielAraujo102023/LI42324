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
    public partial class VinilTests : Form
    {

        private string userInput;
        BindingSource vinilBinding = new BindingSource();
        VinilDAO vinilDAO = new VinilDAO();
        public VinilTests()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //vinilBinding.DataSource = vinilDAO.GetListVinis();
            List<Vinil> vinis = vinilDAO.GetListVinis();



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
