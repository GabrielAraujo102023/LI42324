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

        private void button2_Click(object sender, EventArgs e)
        {
            int? comprador = null;
            float? precoVenda = null;
            string estado = textBox1.Text;
            // Check if textBox2.Text is not empty and parse the value
            if (!string.IsNullOrEmpty(textBox2.Text) && int.TryParse(textBox2.Text, out int parsedComprador))
            {
                comprador = parsedComprador;
            }

            // Check if textBox1.Text is not empty
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                estado = textBox1.Text;
            }

            float valorBase = float.Parse(textBox3.Text);
            float valorMinimo = float.Parse(textBox4.Text);
            // Check if textBox5.Text is not empty and parse the value
            if (!string.IsNullOrEmpty(textBox5.Text) && float.TryParse(textBox5.Text, out float parsedPrecoVenda))
            {
                // Parsing successful, set the value
                precoVenda = parsedPrecoVenda;
            }
            int vendedor = int.Parse(textBox6.Text);
            Leilao leilaotmp = new Leilao(estado, comprador, valorBase, valorMinimo, precoVenda, vendedor);
            int leilaoid = leilaoDAO.InsertLeilao(leilaotmp);
            Leilao leilao = new Leilao(leilaoid, estado, comprador, valorBase, valorMinimo, precoVenda, vendedor);
            MessageBox.Show(leilao.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            int idLeilao = int.Parse(textBox7.Text);
            int? comprador = null;
            float? precoVenda = null;
            string estado = textBox1.Text;
            // Check if textBox2.Text is not empty and parse the value
            if (!string.IsNullOrEmpty(textBox2.Text) && int.TryParse(textBox2.Text, out int parsedComprador))
            {
                comprador = parsedComprador;
            }

            // Check if textBox1.Text is not empty
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                estado = textBox1.Text;
            }

            float valorBase = float.Parse(textBox3.Text);
            float valorMinimo = float.Parse(textBox4.Text);
            // Check if textBox5.Text is not empty and parse the value
            if (!string.IsNullOrEmpty(textBox5.Text) && float.TryParse(textBox5.Text, out float parsedPrecoVenda))
            {
                // Parsing successful, set the value
                precoVenda = parsedPrecoVenda;
            }
            int vendedor = int.Parse(textBox6.Text);
            Leilao leilao = new Leilao(estado, comprador, valorBase, valorMinimo, precoVenda, vendedor);
            leilaoDAO.UpdateLeilao(idLeilao, leilao);
            
            //leilaoDAO.UpdateLeilaoComprado(idLeilao, 4, 30);

        }
    }
}
