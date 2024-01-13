using System;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;


namespace SpinToWin
{
    internal class LeilaoDAO
    {
        private static string connectionString = "Data Source=DESKTOP-AQDL94R;Initial Catalog=VinilDB;Integrated Security=True;TrustServerCertificate=True;";

        public List<Leilao> GetListLeiloes()
        {
            List<Leilao> leiloes = new List<Leilao>();
            Leilao leilao = new Leilao();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Leilao";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Access data using reader
                            string estado = reader.GetString(reader.GetOrdinal("Estado"));
                            int? comprador = reader.IsDBNull(reader.GetOrdinal("Comprador")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("Comprador"));
                            float valorBase = (float)reader.GetDouble(reader.GetOrdinal("Valor_base"));
                            float valorMinimo = (float)reader.GetDouble(reader.GetOrdinal("Valor_minimo"));
                            float? precoVenda = reader.IsDBNull(reader.GetOrdinal("Preco_venda")) ? (float?)null : (float)reader.GetDouble(reader.GetOrdinal("Preco_venda"));
                            int vendedor = reader.GetInt32(reader.GetOrdinal("Vendedor"));
                            leilao = new Leilao(estado, comprador, valorBase, valorMinimo, precoVenda, vendedor);
                            Console.WriteLine($"Estado: {estado}, Comprador: {comprador}, " +
                                              $"ValorBase: {valorBase}, ValorMinimo: {valorMinimo}, PrecoVenda: {precoVenda}, Vendedor: {vendedor}");
                            
                            leiloes.Add(leilao);
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                // Handle the exception as needed
            }
            return leiloes;
        }

    }
}
