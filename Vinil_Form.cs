using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpinToWin
{
    public partial class Vinil_Form : Form
    {
        private bool hasImage = false;
        private string url;
        public Vinil_Form()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
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
            if (url_textBox.Text == "")
            {
                MessageBox.Show("Insira um URL.");
            }
            else
            {
                Image loadedImage = LoadImageFromUrl(url_textBox.Text);
                if (loadedImage != null)
                {
                    pictureBox1.Image = loadedImage;
                    url = url_textBox.Text;
                    hasImage = true;
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
                        , (string)tipo_comboBox.SelectedItem, gravadora_textBox.Text, edicaoEspecial_checkBox.Checked, remasterizado_checkBox.Checked, url, Global.accountID, null));
                    MessageBox.Show("Vinil adicionado com sucesso!");
                }
                finally
                {
                    Close();
                }
            }
        }

        private Image LoadImageFromUrl(string imageUrl)
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    byte[] data = webClient.DownloadData(imageUrl);
                    using (MemoryStream ms = new MemoryStream(data))
                    {
                        // Load the image from the MemoryStream and return it
                        return Image.FromStream(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                // If an error occurs, return a default image or handle the error as needed
                Console.WriteLine($"Error loading image: {ex.Message}");

                // Example: Return a default image (you can replace it with your own default image)
                using (WebClient webClient = new WebClient())
                {
                    // Corrected URL and encoded characters
                    string defaultImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT-b_QDl_iVc3fctFPnwbmZ9rq98UBk2vtdMw&usqp=CAU";

                    byte[] data = webClient.DownloadData(defaultImageUrl);
                    using (MemoryStream ms = new MemoryStream(data))
                    {
                        // Load the default image from the MemoryStream and return it
                        return Image.FromStream(ms);
                    }
                }
            }
        }
    }
}
