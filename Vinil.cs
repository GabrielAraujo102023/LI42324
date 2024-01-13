using System;

namespace SpinToWin
{
    internal class Vinil
    {
        // Attributes
        public int? IdVinil { get; set; }
        public string Artista { get; set; }
        public string Album { get; set; }
        public DateTime? AnoLancamento { get; set; }
        public int? CondicaoDisco { get; set; }
        public int? CondicaoCapa { get; set; }
        public string Categoria { get; set; }
        public int? Duracao { get; set; }
        public int? Tamanho { get; set; }
        public int? Rotacoes { get; set; }
        public string Tipo { get; set; }
        public string Gravadora { get; set; }
        public bool? EdicaoEspecial { get; set; }
        public bool? Remasterizado { get; set; }
        public string FotosVinil { get; set; }
        public int Cliente { get; set; }
        public int? Leilao { get; set; }

        // Constructors
        public Vinil()
        {
            // Default constructor
        }

        // Constructor without id
        public Vinil(string artista, string album, DateTime? anoLancamento,
                     int? condicaoDisco, int? condicaoCapa, string categoria, int? duracao,
                     int? tamanho, int? rotacoes, string tipo, string gravadora,
                     bool? edicaoEspecial, bool? remasterizado, string fotosVinil,
                     int cliente, int? leilao)
        {
            Artista = artista;
            Album = album;
            AnoLancamento = anoLancamento;
            CondicaoDisco = condicaoDisco;
            CondicaoCapa = condicaoCapa;
            Categoria = categoria;
            Duracao = duracao;
            Tamanho = tamanho;
            Rotacoes = rotacoes;
            Tipo = tipo;
            Gravadora = gravadora;
            EdicaoEspecial = edicaoEspecial;
            Remasterizado = remasterizado;
            FotosVinil = fotosVinil;
            Cliente = cliente;
            Leilao = leilao;
        }

        // Constructor with id
        public Vinil(int? idVinil, string artista, string album, DateTime? anoLancamento,
                    int? condicaoDisco, int? condicaoCapa, string categoria, int? duracao,
                    int? tamanho, int? rotacoes, string tipo, string gravadora,
                    bool? edicaoEspecial, bool? remasterizado, string fotosVinil,
                    int cliente, int? leilao)
        {
            IdVinil = idVinil;
            Artista = artista;
            Album = album;
            AnoLancamento = anoLancamento;
            CondicaoDisco = condicaoDisco;
            CondicaoCapa = condicaoCapa;
            Categoria = categoria;
            Duracao = duracao;
            Tamanho = tamanho;
            Rotacoes = rotacoes;
            Tipo = tipo;
            Gravadora = gravadora;
            EdicaoEspecial = edicaoEspecial;
            Remasterizado = remasterizado;
            FotosVinil = fotosVinil;
            Cliente = cliente;
            Leilao = leilao;
        }

        // Clone method
        public Vinil Clone()
        {
            return new Vinil
            {
                IdVinil = this.IdVinil,
                Artista = this.Artista,
                Album = this.Album,
                AnoLancamento = this.AnoLancamento,
                CondicaoDisco = this.CondicaoDisco,
                CondicaoCapa = this.CondicaoCapa,
                Categoria = this.Categoria,
                Duracao = this.Duracao,
                Tamanho = this.Tamanho,
                Rotacoes = this.Rotacoes,
                Tipo = this.Tipo,
                Gravadora = this.Gravadora,
                EdicaoEspecial = this.EdicaoEspecial,
                Remasterizado = this.Remasterizado,
                FotosVinil = this.FotosVinil,
                Cliente = this.Cliente,
                Leilao = this.Leilao
            };
        }

        // ToString method
        public override string ToString()
        {
            return $"Id={IdVinil}, Artista={Artista}, Album={Album}, AnoLancamento={AnoLancamento}, " +
                   $"CondicaoDisco={CondicaoDisco}, CondicaoCapa={CondicaoCapa}, Categoria={Categoria}, " +
                   $"Duracao={Duracao}, Tamanho={Tamanho}, Rotacoes={Rotacoes}, Tipo={Tipo}, Gravadora={Gravadora}, " +
                   $"EdicaoEspecial={EdicaoEspecial}, Remasterizado={Remasterizado}, FotosVinil={FotosVinil}, " +
                   $"Cliente={Cliente}, Leilao={Leilao}]";
        }
    }
}
