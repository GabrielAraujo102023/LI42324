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
    public partial class Ajuda_Form : Form
    {
        Home_Form home_form;
        public Ajuda_Form(Home_Form home_form)
        {
            InitializeComponent();
            this.home_form = home_form;
            Refresh();
        }

        private void sair_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_vender_Click(object sender, EventArgs e)
        {

        }

        private void logout_button_Click(object sender, EventArgs e)
        {

        }

        private void perfil_button_Click(object sender, EventArgs e)
        {
        }

        public override void Refresh()
        {
            base.Refresh();
        }

        private void btn_leiloes_Click(object sender, EventArgs e)
        {
            home_form.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
