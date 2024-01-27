﻿using System;
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

        public Comprar_Leilao_Form(Leilao l, String nomeVendedor, Client user, List<Vinil> vinis)
        {

            this.leilao = l;
            this.nomeVendedor = nomeVendedor;
            this.user = user;
            this.idVendedor = l.Vendedor;
            this.vinis = vinis;
            InitializeComponent();
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
                    label6.Text = $"Tempo até iniciar leilão: TODO";
                    label5.Visible = false;
                    label4.Visible = false;
                    button1.Visible = false;
                    break;

                case "aberto":
                    label2.Text = $"Preço Atual: {leilao.ValorBase}";
                    label3.Text = $"Preço Mínimo: {leilao.ValorMinimo}";
                    label4.Text = $"Tempo até próximo decremento: TODO";
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

                default:
                    break;
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }


        private double calcProxPreco(Leilao leilao)
        {
            double proxPreco = leilao.ValorBase;
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
            if (user.Dinheiro < leilao.ValorBase)
            {
                MessageBox.Show("Não tem dinheiro suficiente para comprar este vinil");
            }
            else
            {
                VinilDAO vinilDAO = new VinilDAO();
                user.Dinheiro -= leilao.ValorBase;
                ClientDAO clientDAO = new ClientDAO();
                clientDAO.UpdateClient(user);
                MessageBox.Show("Compra efetuada com sucesso");
                leilao.Estado = "fechado";
                leilao.Comprador = user.Id;
                leilao.PrecoVenda = leilao.ValorBase;
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
        }
    
}
