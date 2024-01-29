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
                            int id = reader.GetInt32(reader.GetOrdinal("idLeilao"));
                            string estado = reader.GetString(reader.GetOrdinal("Estado"));
                            int? comprador = reader.IsDBNull(reader.GetOrdinal("Comprador")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("Comprador"));
                            float valorBase = (float)reader.GetDouble(reader.GetOrdinal("Valor_base"));
                            float valorMinimo = (float)reader.GetDouble(reader.GetOrdinal("Valor_minimo"));
                            DateTime TempoCriacao = reader.GetDateTime(reader.GetOrdinal("TempoCriacao"));
                            float precoVenda = (float)reader.GetDouble(reader.GetOrdinal("Preco_venda"));
                            int vendedor = reader.GetInt32(reader.GetOrdinal("Vendedor"));
                            leilao = new Leilao(id, estado, comprador, valorBase, valorMinimo, TempoCriacao, precoVenda, vendedor);
                            Console.WriteLine($"Id: {id}, Estado: {estado}, Comprador: {comprador}, " +
                                            $"ValorBase: {valorBase}, ValorMinimo: {valorMinimo}, TempoCriacao: {TempoCriacao}, PrecoVenda: {precoVenda}, Vendedor: {vendedor}");

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
                    string query = "INSERT INTO Leilao (Estado, Comprador, Valor_base, Valor_minimo, TempoCriacao, Preco_venda, Vendedor) OUTPUT INSERTED.idLeilao VALUES (@Estado, @Comprador, @Valor_base, @Valor_minimo, @TempoCriacao, @Preco_venda, @Vendedor)";
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
                        cmd.Parameters.AddWithValue("@TempoCriacao", leilao.TempoCriacao);

                        cmd.Parameters.AddWithValue("@Preco_venda", leilao.PrecoVenda);

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
                    string query = "UPDATE Leilao SET Estado = @Estado, Comprador = @Comprador, Valor_base = @Valor_base, Valor_minimo = @Valor_minimo, TempoCriacao = @TempoCriacao, Preco_venda = @Preco_venda, Vendedor = @Vendedor WHERE idLeilao = @idLeilao";
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
                        cmd.Parameters.AddWithValue("@TempoCriacao", leilao.TempoCriacao);
                        cmd.Parameters.AddWithValue("@Preco_venda", leilao.PrecoVenda);
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

        public void DeleteLeilao(int idLeilao)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Leilao WHERE idLeilao = @idLeilao";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@idLeilao", idLeilao);
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

        public Leilao GetLeilaoById (int idLeilao)
        {
            Leilao res = new Leilao();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Leilao WHERE idLeilao = @idLeilao";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@idLeilao", idLeilao);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Access data using reader
                                int id = reader.GetInt32(reader.GetOrdinal("idLeilao"));
                                string estado = reader.GetString(reader.GetOrdinal("Estado"));
                                int? comprador = reader.IsDBNull(reader.GetOrdinal("Comprador")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("Comprador"));
                                float valorBase = (float)reader.GetDouble(reader.GetOrdinal("Valor_base"));
                                float valorMinimo = (float)reader.GetDouble(reader.GetOrdinal("Valor_minimo"));
                                DateTime TempoCriacao = reader.GetDateTime(reader.GetOrdinal("Tempo_criacao"));
                                float precoVenda = (float)reader.GetDouble(reader.GetOrdinal("Preco_venda"));
                                int vendedor = reader.GetInt32(reader.GetOrdinal("Vendedor"));
                                res = new Leilao(id, estado, comprador, valorBase, valorMinimo, TempoCriacao, precoVenda, vendedor);
                                Console.WriteLine($"Id: {id}, Estado: {estado}, Comprador: {comprador}, " +
                                            $"ValorBase: {valorBase}, ValorMinimo: {valorMinimo}, TempoCriacao: {TempoCriacao}, PrecoVenda: {precoVenda}, Vendedor: {vendedor}");
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                // Handle the exception as needed
            }
            return res;
        }

        public List<Leilao> GetLeilaoByVendedor(int idClient)
        {
            List<Leilao> res = new List<Leilao>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Leilao WHERE Vendedor = @idClient";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@idClient", idClient);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Access data using reader
                                int id = reader.GetInt32(reader.GetOrdinal("idLeilao"));
                                string estado = reader.GetString(reader.GetOrdinal("Estado"));
                                int? comprador = reader.IsDBNull(reader.GetOrdinal("Comprador")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("Comprador"));
                                float valorBase = (float)reader.GetDouble(reader.GetOrdinal("Valor_base"));
                                float valorMinimo = (float)reader.GetDouble(reader.GetOrdinal("Valor_minimo"));
                                DateTime TempoCriacao = reader.GetDateTime(reader.GetOrdinal("Tempo_criacao"));
                                float precoVenda = (float)reader.GetDouble(reader.GetOrdinal("Preco_venda"));
                                int vendedor = reader.GetInt32(reader.GetOrdinal("Vendedor"));
                                res.Add(new Leilao(id, estado, comprador, valorBase, valorMinimo, TempoCriacao, precoVenda, vendedor));
                                Console.WriteLine($"Id: {id}, Estado: {estado}, Comprador: {comprador}, " +
                                            $"ValorBase: {valorBase}, ValorMinimo: {valorMinimo}, PrecoVenda: {precoVenda}, Vendedor: {vendedor}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                // Handle the exception as needed
            }
            return res;
        }

        public List<Leilao> GetLeilaoByComprador(int idClient)
        {
            List<Leilao> res = new List<Leilao>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Leilao WHERE Comprador = @idClient";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@idClient", idClient);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Access data using reader
                                int id = reader.GetInt32(reader.GetOrdinal("idLeilao"));
                                string estado = reader.GetString(reader.GetOrdinal("Estado"));
                                int? comprador = reader.IsDBNull(reader.GetOrdinal("Comprador")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("Comprador"));
                                float valorBase = (float)reader.GetDouble(reader.GetOrdinal("Valor_base"));
                                float valorMinimo = (float)reader.GetDouble(reader.GetOrdinal("Valor_minimo"));
                                DateTime TempoCriacao = reader.GetDateTime(reader.GetOrdinal("Tempo_criacao"));
                                float precoVenda = (float)reader.GetDouble(reader.GetOrdinal("Preco_venda"));
                                int vendedor = reader.GetInt32(reader.GetOrdinal("Vendedor"));
                                res.Add(new Leilao(id, estado, comprador, valorBase, valorMinimo, TempoCriacao, precoVenda, vendedor));
                                Console.WriteLine($"Id: {id}, Estado: {estado}, Comprador: {comprador}, " +
                                            $"ValorBase: {valorBase}, ValorMinimo: {valorMinimo}, PrecoVenda: {precoVenda}, Vendedor: {vendedor}");
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                // Handle the exception as needed
            }
            return res;
        }
    }
}
