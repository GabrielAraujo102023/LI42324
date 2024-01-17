using System;

namespace SpinToWin
{
    internal class Leilao
    {
        public int? IdLeilao { get; set; }
        public string Estado { get; set; }
        public int? Comprador { get; set; }
        public float ValorBase { get; set; }
        public float ValorMinimo { get; set; }
        public float PrecoVenda { get; set; }
        public int Vendedor { get; set; }

        // Default constructor
        public Leilao()
        {
        }

        // Constructor without id
        public Leilao(string estado, int? comprador, float valorBase, float valorMinimo, float precoVenda, int vendedor)
        {
            Estado = estado;
            Comprador = comprador;
            ValorBase = valorBase;
            ValorMinimo = valorMinimo;
            PrecoVenda = precoVenda;
            Vendedor = vendedor;
        }

        // Constructor with id
        public Leilao(int? idLeilao, string estado, int? comprador, float valorBase, float valorMinimo, float precoVenda, int vendedor)
        {
            IdLeilao = idLeilao;
            Estado = estado;
            Comprador = comprador;
            ValorBase = valorBase;
            ValorMinimo = valorMinimo;
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
            PrecoVenda = other.PrecoVenda;
            Vendedor = other.Vendedor;
        }

        public override string ToString()
        {
            return $"Id : {IdLeilao}, Estado: {Estado}, Comprador: {Comprador}, " +
                   $"ValorBase: {ValorBase}, ValorMinimo: {ValorMinimo}, PrecoVenda: {PrecoVenda}, Vendedor: {Vendedor}";
        }
    }
}
