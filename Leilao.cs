using System;

namespace SpinToWin
{
    public class Leilao
    {
        public int? IdLeilao { get; set; }
        public string Estado { get; set; }
        public int? Comprador { get; set; }
        public float ValorBase { get; set; }
        public float ValorMinimo { get; set; }
        public DateTime TempoCriacao { get; set; }
        public float PrecoVenda { get; set; }
        public int Vendedor { get; set; }

        // Default constructor
        public Leilao()
        {
        }

        // Constructor without id
        public Leilao(string estado, int? comprador, float valorBase, float valorMinimo, DateTime tempoCriacao,  float precoVenda, int vendedor)
        {
            Estado = estado;
            Comprador = comprador;
            ValorBase = valorBase;
            ValorMinimo = valorMinimo;
            TempoCriacao = tempoCriacao;
            PrecoVenda = precoVenda;
            Vendedor = vendedor;
        }

        // Constructor with id
        public Leilao(int? idLeilao, string estado, int? comprador, float valorBase, float valorMinimo, DateTime tempoCriacao, float precoVenda, int vendedor)
        {
            IdLeilao = idLeilao;
            Estado = estado;
            Comprador = comprador;
            ValorBase = valorBase;
            ValorMinimo = valorMinimo;
            TempoCriacao = tempoCriacao;
            PrecoVenda = precoVenda;
            Vendedor = vendedor;
        }

        // Copy constructor
        public Leilao(Leilao other)
        {
            IdLeilao = other.IdLeilao;
            Estado = other.Estado;
            Comprador = other.Comprador;
            ValorBase = other.ValorBase;
            ValorMinimo = other.ValorMinimo;
            TempoCriacao = other.TempoCriacao;
            PrecoVenda = other.PrecoVenda;
            Vendedor = other.Vendedor;
        }

        public override string ToString()
        {
            return $"Id : {IdLeilao}, Estado: {Estado}, Comprador: {Comprador}, " +
                   $"ValorBase: {ValorBase}, ValorMinimo: {ValorMinimo}, TempoCriacao: {TempoCriacao} PrecoVenda: {PrecoVenda}, Vendedor: {Vendedor}";
        }
    }
}
