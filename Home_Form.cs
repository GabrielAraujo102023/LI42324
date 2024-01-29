using Microsoft.Identity.Client.NativeInterop;
using Microsoft.IdentityModel.Tokens;
using System.Windows.Forms;
using System.Net;

namespace SpinToWin
{
    public partial class Home_Form : Form
    {
        private static ClientDAO clientDAO = new ClientDAO();
        private static LeilaoDAO leilaoDAO = new LeilaoDAO();
        private static VinilDAO vinilDAO = new VinilDAO();
        private static List<Leilao> leiloesCompletos = leilaoDAO.GetListLeiloes();
        private static List<Leilao> leiloes = new List<Leilao>(leiloesCompletos);
        private static int nItems = 12;
        private int curPagina = 0;
        private int maxPaginas = leiloes.Count() / nItems;

        public Home_Form()
        {
            InitializeComponent();
            curr_time.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            carregarLeiloes();
            Refresh();
            new TimeManager().Run();
        }

        public void reloadLeiloes()
        {
            leilaoDAO = new LeilaoDAO();
            leiloes = leilaoDAO.GetListLeiloes();
            carregarLeiloes();
        }


        public void carregarLeiloes()
        {
            int start = 0 + (nItems * curPagina);
            int nGet = nItems;
            if (start + nItems >= leiloes.Count())
            {
                nGet = leiloes.Count() - start;
            }
            List<Leilao> leiloesPagina = leiloes.GetRange(start, nGet);
            tableLayoutPanel1.Controls.Clear();
            foreach (Leilao l in leiloesPagina)
            {
                FlowLayoutPanel p = new FlowLayoutPanel();
                p.Size = new Size(700, 700);
                p.FlowDirection = FlowDirection.LeftToRight;
                String emailVendedor = clientDAO.GetClientbyID(l.Vendedor).Email;

                Button btn = new Button();
                btn.Text = "Info";
                btn.Size = new Size(88, 30); // Defina o tamanho desejado aqui
                btn.Margin = new Padding(0); // Remove a margem ao redor do botão
                btn.TextAlign = ContentAlignment.MiddleCenter;

                Label estado = new Label();
                estado.Text = l.Estado;
                estado.BackColor = colorText(estado.Text);
                estado.Size = btn.Size;
                estado.Margin = new Padding(50, 0, 0, 0);
                estado.TextAlign = ContentAlignment.MiddleCenter;

                // Botao de Info
                btn.Click += (sender, e) =>
                {
                    List<Vinil> vinis = vinilDAO.GetVinisByLeilao((int)l.IdLeilao);
                    // Passa o leilão 'l' para o formulário
                    new Leilao_Info_Form(l, vinis).Show();
                };


                PictureBox pict = new PictureBox();
                List<Vinil> vinis = vinilDAO.GetVinisByLeilao((int)l.IdLeilao);

                pict.Click += (sender, e) =>
                {
                    Client c = clientDAO.GetClientbyID(Global.accountID);
                    new Comprar_Leilao_Form(l, emailVendedor, c, vinis).Show();
                };


                Image loadedImage = null;

                foreach (Vinil vinil in vinis)
                {
                    if (LoadImageFromUrl(vinil.FotosVinil, out loadedImage))
                    {
                        // If the image loads successfully, break out of the loop
                        break;
                    }
                }

                // If loadedImage is still null, use the default image
                if (loadedImage == null)
                {
                    LoadImageFromUrl("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT-b_QDl_iVc3fctFPnwbmZ9rq98UBk2vtdMw&usqp=CAU", out loadedImage);
                }

                // Assign the loaded or default image to pict.Image
                pict.Image = loadedImage;

                Label titulo = new Label();
                titulo.Width = 270;
                titulo.Text = "               Vendedor: " + emailVendedor;

                Label preco = new Label();
                preco.Width = 270;
                preco.Text = "                Preço: " + l.PrecoVenda + "€";
                preco.Margin = new Padding(0, 0, 0, 15);

                pict.SizeMode = PictureBoxSizeMode.Zoom;
                pict.Size = new Size(270, 170);
                p.Controls.Add(estado);
                pict.Location = estado.Location;
                pict.Margin = new Padding(0); // Remove a margem ao redor do label
                p.Controls.Add(btn);
                p.Controls.Add(pict);

                p.Controls.Add(titulo);
                p.Controls.Add(preco);
                tableLayoutPanel1.Controls.Add(p);
            }
        }

        Color colorText(string estado)
        {
            switch (estado)
            {
                case "fechado":
                    return Color.Red;
                case "aberto":
                    return Color.Green;
                case "catalogado":
                    return Color.Yellow;
                case "lastChance":
                    return Color.Orange;
                default: return Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //Botão de Ajuda
        private void button2_Click(object sender, EventArgs e)
        {
            new Ajuda_Form(this).Show();
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public override void Refresh()
        {
            if (Global.isLoggedIn)
            {
                logout_button.Text = "Logout";
                perfil_button.Visible = true;
                if (Global.accountID == 0)
                {
                    editlei_button.Visible = true;
                    editvin_button.Visible = true;
                    editcl_button.Visible = true;
                }
            }
            else
            {
                //TODO por isto falso again
                logout_button.Text = "Login";
                perfil_button.Visible = false;
                editlei_button.Visible = true;
                editvin_button.Visible = true;
                editcl_button.Visible = true;
            }
            base.Refresh();
        }

        // BOTÃO DE LOGOUT
        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Global.isLoggedIn = false;
            new Login_Form(this).Show();
        }

        // BOTÃO DE SAIR
        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormTests formTests = new FormTests();
            formTests.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            VinilTests vinilTests = new VinilTests();
            vinilTests.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LeilaoTests leilaoTests = new LeilaoTests();
            leilaoTests.Show();
        }

        private void nextPage_button_Click(object sender, EventArgs e)
        {
            if (curPagina < maxPaginas)
            {
                curPagina++;
                carregarLeiloes();
            }
        }

        private void pesquisar_button_Click(object sender, EventArgs e)
        {
            processarLeiloes();
        }

        private void processarLeiloes()
        {
            leiloes = !txtBox_pesquisar.Text.IsNullOrEmpty() ? leilaoDAO.GetListLeiloes().FindAll(matchesSearch) : leilaoDAO.GetListLeiloes();
            ordenarLeiloes();
            filtrarLeiloes();
            curPagina = 0;
            carregarLeiloes();
        }

        private void filtrarLeiloes()
        {
            // Filtrar por estado
            if (!Aberto.Checked)
            {
                leiloes = leiloes.FindAll(l => l.Estado != "aberto");
            }
            if (!Catalogado.Checked)
            {
                leiloes = leiloes.FindAll(l => l.Estado != "catalogado");
            }
            if (!Fechado.Checked)
            {
                leiloes = leiloes.FindAll(l => l.Estado != "fechado");
            }
            if (!lastChance.Checked)
            {
                leiloes = leiloes.FindAll(l => l.Estado != "lastChance");
            }

            // Filtrar por ano
            if (a_partir_ano.Text != "")
            {
                int targetYear = int.Parse(a_partir_ano.Text);

                leiloes = leiloes.Where(l =>
                {
                    List<Vinil> vinis = vinilDAO.GetVinisByLeilao((int)l.IdLeilao);
                    return vinis.Any(v => v.AnoLancamento.HasValue && v.AnoLancamento.Value.Year >= targetYear);
                }).ToList();
            }

            // Filtrar por categoria
            if (genero_musical.Text != "")
            {
                string targetCategory = genero_musical.Text;

                leiloes = leiloes.Where(l =>
                {
                    List<Vinil> vinis = vinilDAO.GetVinisByLeilao((int)l.IdLeilao);
                    return vinis.Any(v => v.Categoria == targetCategory);
                }).ToList();
            }

            // Filtrar por qualidade da capa
            if (min_qualidade_capa.Text != "")
            {
                int targetCapa = int.Parse(min_qualidade_capa.Text[0].ToString());
                leiloes = leiloes.Where(l =>
                {
                    List<Vinil> vinis = vinilDAO.GetVinisByLeilao((int)l.IdLeilao);
                    return vinis.Any(v => v.CondicaoCapa <= targetCapa);
                }).ToList();
            }

            //Filtra por qualidade do disco
            if (min_qualidade_disco.Text != "")
            {
                int targetDisco = int.Parse(min_qualidade_disco.Text[0].ToString());
                leiloes = leiloes.Where(l =>
                {
                    List<Vinil> vinis = vinilDAO.GetVinisByLeilao((int)l.IdLeilao);
                    return vinis.Any(v => v.CondicaoDisco <= targetDisco);
                }).ToList();
            }

            // Filtrar por preço minimo
            if (preco_min.Text != "")
            {
                float targetPrice = float.Parse(preco_min.Text);

                leiloes = leiloes.Where(l => l.PrecoVenda >= targetPrice).ToList();
            }

            // Filtrar por preço maximo
            if (preco_max.Text != "")
            {
                float targetPrice = float.Parse(preco_max.Text);

                leiloes = leiloes.Where(l => l.PrecoVenda <= targetPrice).ToList();
            }

            //Filtrar por numero de vinis
            if (num_min_vinis.Text != "")
            {
                int targetNum = int.Parse(num_min_vinis.Text);

                leiloes = leiloes.Where(l =>
                {
                    List<Vinil> vinis = vinilDAO.GetVinisByLeilao((int)l.IdLeilao);
                    return vinis.Count >= targetNum;
                }).ToList();
            }
            if (num_max_vinis.Text != "")
            {
                int targetNum = int.Parse(num_max_vinis.Text);

                leiloes = leiloes.Where(l =>
                {
                    List<Vinil> vinis = vinilDAO.GetVinisByLeilao((int)l.IdLeilao);
                    return vinis.Count <= targetNum;
                }).ToList();
            }
        }





        private bool matchesSearch(Leilao l)
        {
            string text = txtBox_pesquisar.Text.ToLower();
            List<Vinil> vinis = vinilDAO.GetVinisByLeilao((int)l.IdLeilao);
            foreach (Vinil v in vinis)
            {
                if (v.Album.ToLower().Contains(text) || v.Artista.ToLower().Contains(text))
                    return true;
            }
            return false;
        }

        private void ordenarLeiloes()
        {
            switch (ordenar_combo.SelectedItem)
            {
                case "Preço (Asc.)":
                    leiloes.Sort((a, b) => b.PrecoVenda.CompareTo(a.PrecoVenda));
                    break;
                case "Preço (Des.)":
                    leiloes.Sort((a, b) => a.PrecoVenda.CompareTo(b.PrecoVenda));
                    break;
                case "Nº Vinis (Asc.)":
                    leiloes.Sort((a, b) => vinilDAO.GetVinisByLeilao((int)b.IdLeilao).Count.CompareTo(vinilDAO.GetVinisByLeilao((int)a.IdLeilao).Count));
                    break;
                case "Nº Vinis (Des.)":
                    leiloes.Sort((a, b) => vinilDAO.GetVinisByLeilao((int)a.IdLeilao).Count.CompareTo(vinilDAO.GetVinisByLeilao((int)b.IdLeilao).Count));
                    break;
                case "Tempo restante (Asc.)":
                    leiloes.Sort((a, b) => tempoRestante(b.ValorBase, b.ValorMinimo, b.PrecoVenda).CompareTo(tempoRestante(a.ValorBase, a.ValorMinimo, a.PrecoVenda)));
                    break;
                case "Tempo restante (Des.)":
                    leiloes.Sort((a, b) => tempoRestante(a.ValorBase, a.ValorMinimo, a.PrecoVenda).CompareTo(tempoRestante(b.ValorBase, b.ValorMinimo, b.PrecoVenda)));
                    break;
                default: break;
            }
        }

        public int tempoRestante(float valorBase, float valorMinimo, float valorAtual)
        {
            float decrescimo = valorBase * 0.02f;
            int horas = 0;
            while (valorAtual > valorMinimo)
            {
                valorAtual -= decrescimo;
                horas++;
            }
            horas += 12;
            return horas;
        }

        private void Home_Form_Load(object sender, EventArgs e)
        {

        }

        private void btn_vender_Click(object sender, EventArgs e)
        {
            if (Global.isLoggedIn)
            {
                Hide();
                new CriarLeilao_Form(this).Show();
            }
            else
            {
                MessageBox.Show("Necessita de uma conta para criar um leilão.");
            }
        }

        // Perfil
        private void button5_Click(object sender, EventArgs e)
        {
            new Perfil_Form().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public static bool LoadImageFromUrl(string imageUrl, out Image image)
        {
            image = null;
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    byte[] data = webClient.DownloadData(imageUrl);
                    using (MemoryStream ms = new MemoryStream(data))
                    {
                        // Load the image from the MemoryStream
                        image = Image.FromStream(ms);
                        return true; // Image loaded successfully
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

                    try
                    {
                        byte[] data = webClient.DownloadData(defaultImageUrl);
                        using (MemoryStream ms = new MemoryStream(data))
                        {
                            // Load the default image from the MemoryStream and return it
                            image = Image.FromStream(ms);
                            Console.WriteLine("Loaded default image");
                            return false;
                        }
                    }
                    catch (Exception defaultEx)
                    {
                        Console.WriteLine($"Error loading default image: {defaultEx.Message}");
                        return false;
                    }
                }
            }
        }




        private void prevPage_button_Click_1(object sender, EventArgs e)
        {
            if (curPagina > 0)
            {
                curPagina--;
                carregarLeiloes();
            }
        }

        private void ordenar_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void a_partir_ano_TextChanged(object sender, EventArgs e)
        {

        }

        private void aplicar_filtros_Click(object sender, EventArgs e)
        {
            leiloes = new List<Leilao>(leiloesCompletos);
            processarLeiloes();
        }

        private void Fechado_CheckedChanged(object sender, EventArgs e)
        {
            leiloes = new List<Leilao>(leiloesCompletos);
            processarLeiloes();
        }

        private void lastChance_CheckedChanged(object sender, EventArgs e)
        {
            leiloes = new List<Leilao>(leiloesCompletos);
            processarLeiloes();
        }

        private void Aberto_CheckedChanged(object sender, EventArgs e)
        {
            leiloes = new List<Leilao>(leiloesCompletos);
            processarLeiloes();
        }

        private void Catalogado_CheckedChanged(object sender, EventArgs e)
        {
            leiloes = new List<Leilao>(leiloesCompletos);
            processarLeiloes();
        }

        private void curr_time_Click(object sender, EventArgs e)
        {

        }
    }
}
