using Google.Apis.Gmail.v1.Data;
using Google.Apis.Gmail.v1;
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


//hora em hora baixa 2% do preço
//fica 12 horas em catalogado
//fica 12 horas no preço mínimo

//preciso: nome venderdor

{
    public partial class Comprar_Leilao_Form : Form
    {

        private Leilao leilao;
        private String nomeVendedor;
        private Client user;
        private int idVendedor;
        private List<Vinil> vinis;
        VinilDAO vinilDAO = new VinilDAO();

        public Comprar_Leilao_Form(Leilao l, String nomeVendedor, Client user, List<Vinil> vinis)
        {

            this.leilao = l;
            this.nomeVendedor = nomeVendedor;
            this.user = user;
            this.idVendedor = l.Vendedor;
            this.vinis = vinis;
            InitializeComponent();
            carregarVinis();
        }

        private void carregarVinis()
        {
            BindingSource binding = new BindingSource();
            binding.DataSource = GetVinisInfo();
            Console.WriteLine(binding.DataSource.ToString());
            dataGridView1.DataSource = binding;
            dataGridView1.Columns["IdVinil"].Visible = false;
        }

        private List<VinilInfo> GetVinisInfo()
        {
            List<VinilInfo> info = new List<VinilInfo>();
            foreach (Vinil v in vinis)
            {
                info.Add(new VinilInfo(v));
            }
            return info;
        }

        private void Comprar_Leilao_Form_Load(object sender, EventArgs e)
        {
            double proxPreco = calcProxPreco(leilao);
            email_vendedor.Text = $"Leilão do : {nomeVendedor}";
            label7.Text = $"Estado: {leilao.Estado}";

            switch (leilao.Estado)
            {
                case "catalogado":
                    label2.Text = $"Preço Inicial: {leilao.ValorBase}";
                    label3.Text = $"Preço Mínimo: {leilao.ValorMinimo}";
                    label6.Text = $"Tempo até iniciar leilão: " + calcularTempo(leilao);
                    label5.Visible = false;
                    label4.Visible = false;
                    button1.Visible = false;
                    break;

                case "aberto":
                    label2.Text = $"Preço Atual: {leilao.PrecoVenda}";
                    label3.Text = $"Preço Mínimo: {leilao.ValorMinimo}";
                    label4.Text = $"Tempo até próximo decremento: " + calcularTempo(leilao);
                    label5.Text = $"Preço após decremento: {proxPreco}";
                    label6.Visible = false;
                    break;

                case "fechado":
                    label2.Text = $"Preço venda: {leilao.ValorBase}";
                    label3.Text = $"Preço Mínimo: {leilao.ValorMinimo}";
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    button1.Visible = false;
                    break;

                case "lastChance":
                    label2.Text = $"Preço Atual: {leilao.PrecoVenda}";
                    label3.Text = $"Preço Mínimo: {leilao.ValorMinimo}";
                    label4.Text = $"Tempo até fecho: " + calcularTempo(leilao);
                    label5.Visible = false;
                    label6.Visible = false;
                    break;

                default:
                    break;
            }
        }

        private string calcularTempo(Leilao l)
        {
            TimeSpan dif;
            if(l.Estado == "catalogado")
            {
                dif = l.TempoCriacao.AddHours(12) - DateTime.Now;
                return dif.Hours.ToString() + ":" + dif.Minutes.ToString() + ":" + dif.Seconds.ToString();
            }
            else if (l.Estado == "aberto")
            {
                int elapsedHours = TimeManager.calculateHoursElapsed(l.ValorBase, l.PrecoVenda, l.ValorBase * 0.02f) + 11;
                dif = l.TempoCriacao.AddHours(elapsedHours) - DateTime.Now;
                return dif.Minutes.ToString() + ":" + dif.Seconds.ToString();
            }
            else
            {
                int elapsedHours = TimeManager.calculateHoursElapsed(l.ValorBase, l.PrecoVenda, l.ValorBase * 0.02f) + 11;
                dif = l.TempoCriacao.AddHours(elapsedHours) - DateTime.Now;
                return dif.Hours.ToString() + ":" + dif.Minutes.ToString() + ":" + dif.Seconds.ToString();
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }


        private double calcProxPreco(Leilao leilao)
        {
            double proxPreco = leilao.PrecoVenda;
            if (leilao.Estado == "aberto")
            {
                proxPreco -= proxPreco * 0.02;
            }

            return proxPreco;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Global.isLoggedIn)
            {
                MessageBox.Show("Necessita de uma conta para comprar um leilão.");
                return;
            }
            if (Global.accountID == leilao.Vendedor)
            {
                MessageBox.Show("Não pode comprar os seus próprios leilões");
                return;
            }
            if (user.Dinheiro < leilao.ValorBase)
            {
                MessageBox.Show("Não tem dinheiro suficiente para comprar este vinil");
            }
            else
            {
                user.Dinheiro -= leilao.PrecoVenda;
                ClientDAO clientDAO = new ClientDAO();
                clientDAO.UpdateClient(user);
                MessageBox.Show("Compra efetuada com sucesso");
                leilao.Estado = "fechado";

                //==============================EMAIL NOTIFICATION VENDOR===========================

                Client vendedor = clientDAO.GetClientbyID(leilao.Vendedor);
                PassRecovery mail = new PassRecovery("null",vendedor.Email);

                string corpo = $"Prezado Usuário,\n\n"
                            + "O seu Leilão foi Comprado com Sucesso\n\n"
                            + "Obrigado,\nA Equipa Spin2Win";


                Google.Apis.Gmail.v1.Data.Message message = mail.CreateMessage("li4spin2win@gmail.com", vendedor.Email, "Leilão Concluido", corpo);


                mail.SendMessage(mail.GmailService, "li4spin2win@gmail.com", message,0);

                //===========================================================================


                leilao.Comprador = user.Id;
                LeilaoDAO leilaoDAO = new LeilaoDAO();
                leilaoDAO.UpdateLeilao((int)leilao.IdLeilao, leilao);

                foreach (Vinil v in vinis)
                {
                    v.Cliente = (int)user.Id;
                    vinilDAO.UpdateVinil((int)v.IdVinil, v);
                }
            }

            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Image loadedImage;

            if (Home_Form.LoadImageFromUrl(vinis.ElementAt(e.RowIndex).FotosVinil, out loadedImage))
            {
                pictureBox1.Image = loadedImage;
            }
            else
            {
                Console.WriteLine("Error loading image from URL");

                if (!Home_Form.LoadImageFromUrl("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT-b_QDl_iVc3fctFPnwbmZ9rq98UBk2vtdMw&usqp=CAU", out loadedImage))
                {
                    MessageBox.Show("Error loading default image");
                }
                else
                {
                    pictureBox1.Image = loadedImage;
                }
            }
        }

    }
}
