using System;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;


namespace SpinToWin
{
    internal class LeilaoDAO
    {
        private static string connectionString = "Data Source=(local);Initial Catalog=VinilDB;Integrated Security=True;TrustServerCertificate=True;";

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

        public int InsertLeilao(Leilao leilao)
        {
            int insertedId = -1; // Default value if insertion fails
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Leilao (Estado, Comprador, Valor_base, Valor_minimo, Preco_venda, Vendedor) OUTPUT INSERTED.idLeilao VALUES (@Estado, @Comprador, @Valor_base, @Valor_minimo, @Preco_venda, @Vendedor)";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Estado", leilao.Estado);

                        // Check for null before setting the parameter value
                        if (leilao.Comprador.HasValue)
                            cmd.Parameters.AddWithValue("@Comprador", leilao.Comprador.Value);
                        else
                            cmd.Parameters.AddWithValue("@Comprador", DBNull.Value);

                        cmd.Parameters.AddWithValue("@Valor_base", leilao.ValorBase);
                        cmd.Parameters.AddWithValue("@Valor_minimo", leilao.ValorMinimo);

                        // Check for null before setting the parameter value
                        if (leilao.PrecoVenda.HasValue)
                            cmd.Parameters.AddWithValue("@Preco_venda", leilao.PrecoVenda.Value);
                        else
                            cmd.Parameters.AddWithValue("@Preco_venda", DBNull.Value);

                        cmd.Parameters.AddWithValue("@Vendedor", leilao.Vendedor);

                        // Execute the query and get the inserted id
                        insertedId = (int)cmd.ExecuteScalar();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                // Handle the exception as needed
            }
            return insertedId;
        }

        public void UpdateLeilao(int idLeilao, Leilao leilao)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Leilao SET Estado = @Estado, Comprador = @Comprador, Valor_base = @Valor_base, Valor_minimo = @Valor_minimo, Preco_venda = @Preco_venda, Vendedor = @Vendedor WHERE idLeilao = @idLeilao";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@idLeilao", idLeilao);
                        cmd.Parameters.AddWithValue("@Estado", leilao.Estado);

                        // Check for null before setting the parameter value
                        if (leilao.Comprador.HasValue)
                            cmd.Parameters.AddWithValue("@Comprador", leilao.Comprador.Value);
                        else
                            cmd.Parameters.AddWithValue("@Comprador", DBNull.Value);

                        cmd.Parameters.AddWithValue("@Valor_base", leilao.ValorBase);
                        cmd.Parameters.AddWithValue("@Valor_minimo", leilao.ValorMinimo);

                        // Check for null before setting the parameter value
                        if (leilao.PrecoVenda.HasValue)
                            cmd.Parameters.AddWithValue("@Preco_venda", leilao.PrecoVenda.Value);
                        else
                            cmd.Parameters.AddWithValue("@Preco_venda", DBNull.Value);

                        cmd.Parameters.AddWithValue("@Vendedor", leilao.Vendedor);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                // Handle the exception as needed
            }
        }

        //método qd leilao é comprado
        public void UpdateLeilaoComprado(int idLeilao, int idComprador, float precoVenda)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Leilao SET  Comprador = @Comprador, Preco_venda = @Preco_venda WHERE idLeilao = @idLeilao";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@idLeilao", idLeilao);
                        cmd.Parameters.AddWithValue("@Comprador", idComprador);
                        cmd.Parameters.AddWithValue("@Preco_venda", precoVenda);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                // Handle the exception as needed
            }
        }
    }
}
