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
    public partial class LeilaoTests : Form
    {

        private string userInput;
        BindingSource leilaoBinding = new BindingSource();
        LeilaoDAO leilaoDAO = new LeilaoDAO();

        public LeilaoTests()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void LeilaoTests_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            leilaoBinding.DataSource = leilaoDAO.GetListLeiloes();
            dataGridView1.DataSource = leilaoBinding;

        }
    }
}
