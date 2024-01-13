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

        BindingSource vinilBinding = new BindingSource();
        VinilDAO vinilDAO = new VinilDAO();

        Vinil vinil1 = new Vinil(
                artista: "Pink Floyd",
                album: "The Dark Side of the Moon",
                anoLancamento: new DateTime(1973, 1, 1),
                condicaoDisco: 2,
                condicaoCapa: 5,
                categoria: "Rock",
                duracao: 42,
                tamanho: 12,
                rotacoes: 33,
                tipo: "LP",
                gravadora: "Harvest",
                edicaoEspecial: true,
                remasterizado: true,
                fotosVinil: "dark_side.jpg",
                cliente: 1,
                leilao: null
            );

        // Example 2
        Vinil vinil2 = new Vinil(
            artista: "The Beatles",
            album: "Abbey Road",
            anoLancamento: new DateTime(1969, 9, 26),
            condicaoDisco: 3,
            condicaoCapa: 4,
            categoria: "Rock",
            duracao: 47,
            tamanho: 14,
            rotacoes: 45,
            tipo: "LP",
            gravadora: "Apple",
            edicaoEspecial: false,
            remasterizado: false,
            fotosVinil: "abbey_road.jpg",
            cliente: 2,
            leilao: 3
        );


        public VinilTests()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vinilBinding.DataSource = vinilDAO.GetListVinis();
            dataGridView2.DataSource = vinilBinding;




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idVinil = vinilDAO.InsertVinil(vinil1);
            Vinil vinil = new Vinil(idVinil, vinil1.Artista, vinil1.Album, vinil1.AnoLancamento, vinil1.CondicaoDisco, vinil1.CondicaoCapa, vinil1.Categoria, vinil1.Duracao, vinil1.Tamanho, vinil1.Rotacoes, vinil1.Tipo, vinil1.Gravadora, vinil1.EdicaoEspecial, vinil1.Remasterizado, vinil1.FotosVinil, vinil1.Cliente, vinil1.Leilao);
            MessageBox.Show(vinil.ToString());
            int idVinil2 = vinilDAO.InsertVinil(vinil2);
            Vinil vinil3 = new Vinil(idVinil2, vinil2.Artista, vinil2.Album, vinil2.AnoLancamento, vinil2.CondicaoDisco, vinil2.CondicaoCapa, vinil2.Categoria, vinil2.Duracao, vinil2.Tamanho, vinil2.Rotacoes, vinil2.Tipo, vinil2.Gravadora, vinil2.EdicaoEspecial, vinil2.Remasterizado, vinil2.FotosVinil, vinil2.Cliente, vinil2.Leilao);
            Vinil nulo = new Vinil(null, null, null, null, null, null, null, null, null, null, null, null, null, null, 6, null);
            int idVinil3 = vinilDAO.InsertVinil(nulo);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vinil nulo = new Vinil(null, null, null, null, null, null, null, null, null, null, null, null, null, null, 6, null);
            vinilDAO.UpdateVinil(1, nulo);
            vinilDAO.UpdateVinil(9, vinil1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vinilDAO.DeleteVinil(8);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Vinil x = vinilDAO.GetVinilById(1);
            MessageBox.Show(x.ToString());
        }
    }
}
