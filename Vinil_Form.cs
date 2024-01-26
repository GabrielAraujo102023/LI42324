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
    public partial class Vinil_Form : Form
    {
        private bool hasImage = false;
        public Vinil_Form()
        {
            InitializeComponent();
        }

        private void sair_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Vinil_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the filter to allow only image files
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";

            // Set the title of the dialog
            openFileDialog.Title = "Select Picture";

            // Show the dialog and check if the user clicked OK
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                nomeImagem_label.Text = openFileDialog.FileName;
                try
                {
                    // Load the selected image into the PictureBox
                    pictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                    hasImage = true;
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that might occur during image loading
                    MessageBox.Show("Erro a carregar imagem: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (artista_textBox.Text == "")
            {
                MessageBox.Show("Insira o nome do artista.");
            }
            else if (nome_textBox.Text == "")
            {
                MessageBox.Show("Insira o nome do vinil.");
            }
            else if (ano_textBox.Text == "" || !ano_textBox.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Insira um ano de lançamento válido.");
            }
            else if (disco_comboBo.SelectedItem == null)
            {
                MessageBox.Show("Escolha a condição do disco.");
            }
            else if (capa_comboBox.SelectedItem == null)
            {
                MessageBox.Show("Escolha a condição da capa.");
            }
            else if (categoria_comboBox.SelectedItem == null)
            {
                MessageBox.Show("Escolha a categoria do disco.");
            }
            else if (duracao_textBox.Text == "" || !duracao_textBox.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Indique uma duração, em minutos, válida.");
            }
            else if (tamanho_comboBox.SelectedItem == null)
            {
                MessageBox.Show("Selecione um tamanho.");
            }
            else if (rotacoes_comboBox.SelectedItem == null)
            {
                MessageBox.Show("Escolha as rotações do disco.");
            }
            else if (tipo_comboBox.SelectedItem == null)
            {
                MessageBox.Show("Escolha o tipo do disco.");
            }
            else if (gravadora_textBox.Text == "")
            {
                MessageBox.Show("Indique a gravadora do disco.");
            }
            else if (disco_comboBo.SelectedItem == null)
            {
                MessageBox.Show("Escolha a condição do disco.");
            }
            else if (!hasImage)
            {
                MessageBox.Show("Selecione uma imagem.");
            }
            else
            {
                try
                { 
                    new VinilDAO().InsertVinil(new Vinil(artista_textBox.Text, nome_textBox.Text, new DateTime(int.Parse(ano_textBox.Text), 1, 1), disco_comboBo.SelectedIndex + 1
                        , capa_comboBox.SelectedIndex + 1, categoria_comboBox.SelectedText, int.Parse(duracao_textBox.Text), int.Parse((string)tamanho_comboBox.SelectedItem), int.Parse((string)rotacoes_comboBox.SelectedItem)
                        , (string)tipo_comboBox.SelectedItem, gravadora_textBox.Text, edicaoEspecial_checkBox.Checked, remasterizado_checkBox.Checked, nomeImagem_label.Text, Global.accountID, null));
                MessageBox.Show("Vinil adicionado com sucesso!");
                }
                finally
                {
                Close();
            }
        }
    }
}
}
