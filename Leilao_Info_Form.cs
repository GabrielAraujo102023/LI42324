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


        // Ajusta o tamanho do formulário de acordo com a quantidade de vinis
        private void AjustarTamanhoDoFormulario()
        {
            const int alturaPorVinil = 30;
            const int alturaMinima = 100;
            const int alturaMaxima = 500;
            const int larguraFormulario = 300;

            int alturaCalculada = 100 + vinis.Count * alturaPorVinil;

            // Ajusta a altura dentro dos limites mínimos e máximos
            int alturaFinal = Math.Min(Math.Max(alturaCalculada, alturaMinima), alturaMaxima);

            this.Size = new Size(larguraFormulario, alturaFinal);
        }


        private RichTextBox richTextBoxVinis;

        private void InitializeRichTextBox()
        {
            richTextBoxVinis = new RichTextBox();
            richTextBoxVinis.Location = new Point(10, 10); // Ajustar a localização conforme necessário
            richTextBoxVinis.Size = new Size(280, 200); // Ajustar o tamanho conforme necessário
            richTextBoxVinis.ReadOnly = true; // Torna o RichTextBox somente leitura
            richTextBoxVinis.BorderStyle = BorderStyle.None;

            this.Controls.Add(richTextBoxVinis);
        }

        private void Leilao_Info_Form_Load(object sender, EventArgs e)
        {
            InitializeRichTextBox();

            // Adiciona o título
            richTextBoxVinis.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
            richTextBoxVinis.AppendText("Lista de Vinis:\n\n");

            // Adiciona a lista de vinis
            richTextBoxVinis.SelectionFont = new Font("Arial", 10, FontStyle.Regular);
            int contador = 1;
            foreach (var vinil in vinis)
            {
                richTextBoxVinis.AppendText($"{contador} - {vinil.Album}\n");
                contador++;
            }
        }



    }
}
