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
            if (Global.isLoggedIn)
            {
                new CriarLeilao_Form(home_form).Show();
                Close();
            }
            else
            {
                MessageBox.Show("Necessita de uma conta para criar um leilão.");
            }
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            Global.isLoggedIn = false;
            new Login_Form(home_form).Show();
            Close();
        }

        private void perfil_button_Click(object sender, EventArgs e)
        {
            new Perfil_Form().Show();
        }

        public override void Refresh()
        {
            if (Global.isLoggedIn)
            {
                logout_button.Text = "Logout";
                perfil_button.Visible = true;
            }
            else
            {
                logout_button.Text = "Login";
                perfil_button.Visible = false;
            }
            base.Refresh();
        }

        private void btn_leiloes_Click(object sender, EventArgs e)
        {
            home_form.Show();
            Close();
        }
    }
}
