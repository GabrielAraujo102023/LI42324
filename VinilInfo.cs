using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpinToWin
{
    public class VinilInfo
    {
        public int IdVinil { get; private set; }
        public string Nome { get; private set; }
        public string Artista { get; private set; }
        public int Ano { get; private set; }
        public string Categoria { get; private set; }
        public string CondicaoDisco { get; private set; }
        public string CondicaoCapa { get; private set; }
        public int Duracao { get; private set; }
        public string Gravadora { get; private set; }
        public string Remasterizado { get; private set; }
        public string EdicaoEspecial { get; private set; }
        public string Tamanho { get; private set; }
        public string Rotacoes { get; private set; }
        public string Tipo { get; private set; }
        public VinilInfo(Vinil v)
        {
            IdVinil = (int)v.IdVinil;
            Nome = v.Album;
            Artista = v.Artista;
            Ano = v.AnoLancamento.Value.Year;
            Categoria = v.Categoria;
            CondicaoDisco = condicao(v.CondicaoDisco.Value);
            CondicaoCapa = condicao(v.CondicaoCapa.Value);
            Duracao = (int)v.Duracao;
            Gravadora = v.Gravadora;
            Remasterizado = (bool)v.Remasterizado ? "Sim" : "Não";
            EdicaoEspecial = (bool)v.EdicaoEspecial ? "Sim" : "Não";
            Rotacoes = v.Rotacoes.ToString() + " RPM";
            Tipo = v.Tipo;
            Tamanho = v.Tamanho.ToString() + "''";
        }

        public static string condicao(int cond)
        {
            switch (cond)
            {
                case 1:
                    return "Excelente";
                case 2:
                    return "Boa";
                case 3:
                    return "Razoável";
                case 4:
                    return "Má";
                default:
                    return "Terrível";
            }
        }
    }
}
