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
    public partial class Leilao_Info_Form : Form
    {
        private Leilao leilao;
        private List<Vinil> vinis;


        public Leilao_Info_Form(Leilao leilao, List<Vinil> vinis)
        {

            InitializeComponent();
            Point cursorPos = Cursor.Position;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = cursorPos;
            this.leilao = leilao;
            this.vinis = vinis;

            AjustarTamanhoDoFormulario();
        }



        private void AjustarTamanhoDoFormulario()
        {
            const int alturaPorVinil = 30; // Altura estimada por linha de vinil
            const int alturaMinima = 100;  // Altura mínima do formulário
            const int alturaMaxima = 500;  // Altura máxima do formulário
            const int larguraFormulario = 300; // Largura do formulário

            int alturaCalculada = 100 + vinis.Count * alturaPorVinil;

            // Ajusta a altura dentro dos limites mínimos e máximos
            int alturaFinal = Math.Min(Math.Max(alturaCalculada, alturaMinima), alturaMaxima);

            this.Size = new Size(larguraFormulario, alturaFinal);
        }




        private void Leilao_Info_Form_Load(object sender, EventArgs e)
        {
            StringBuilder nomesVinis = new StringBuilder();
            nomesVinis.AppendLine("Lista de Vinis:\n");

            int contador = 1;
            foreach (var vinil in vinis)
            {
                nomesVinis.AppendLine($"{contador}. {vinil.Album}");
                contador++;
            }

            label2.Text = nomesVinis.ToString();
        }



    }
}
