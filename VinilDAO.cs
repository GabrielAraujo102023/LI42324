using System;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;



namespace SpinToWin
{
    internal class VinilDAO
    {
        private static string connectionString = "Data Source=(local);Initial Catalog=VinilDB;Integrated Security=True;TrustServerCertificate=True;";


        public List<Vinil> GetListVinis()
        {
            List<Vinil> vinis = new List<Vinil>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Vinil";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        vinis = readVinis(reader);
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                // Handle the exception as needed
            }
            return vinis;
        }

        public int InsertVinil(Vinil vinil)
        {
            int insertedId = -1; // Default value if insertion fails
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_vinil, Cliente, Leilao) OUTPUT INSERTED.idVinil " +
                        "VALUES (@Artista, @Album, @AnoLancamento, @Condicao_disco, @Condicao_capa, @Categoria, @Duracao, @Tamanho, @Rotacoes, @Tipo, @Gravadora, @Edicao_especial, @Remasterizado, @Fotos_vinil, @Cliente, @Leilao)";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Check for null before setting the parameter value
                        if (vinil.Artista == null)
                            cmd.Parameters.AddWithValue("@Artista", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@Artista", vinil.Artista);

                        // Check for null before setting the parameter value
                        if (vinil.Album == null)
                            cmd.Parameters.AddWithValue("@Album", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@Album", vinil.Album);

                        // Check for null before setting the parameter value
                        if (vinil.AnoLancamento.HasValue)
                            cmd.Parameters.AddWithValue("@AnoLancamento", vinil.AnoLancamento.Value);
                        else
                            cmd.Parameters.AddWithValue("@AnoLancamento", DBNull.Value);

                        // Check for null before setting the parameter value
                        if (vinil.CondicaoDisco.HasValue)
                            cmd.Parameters.AddWithValue("@Condicao_disco", vinil.CondicaoDisco.Value);
                        else
                            cmd.Parameters.AddWithValue("@Condicao_disco", DBNull.Value);

                        // Check for null before setting the parameter value
                        if (vinil.CondicaoCapa.HasValue)
                            cmd.Parameters.AddWithValue("@Condicao_capa", vinil.CondicaoCapa.Value);
                        else
                            cmd.Parameters.AddWithValue("@Condicao_capa", DBNull.Value);

                        // Check for null before setting the parameter value
                        if (vinil.Categoria == null)
                            cmd.Parameters.AddWithValue("@Categoria", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@Categoria", vinil.Categoria);

                        // Check for null before setting the parameter value
                        if (vinil.Duracao.HasValue)
                            cmd.Parameters.AddWithValue("@Duracao", vinil.Duracao.Value);
                        else
                            cmd.Parameters.AddWithValue("@Duracao", DBNull.Value);

                        // Check for null before setting the parameter value
                        if (vinil.Tamanho.HasValue)
                            cmd.Parameters.AddWithValue("@Tamanho", vinil.Tamanho.Value);
                        else
                            cmd.Parameters.AddWithValue("@Tamanho", DBNull.Value);

                        // Check for null before setting the parameter value
                        if (vinil.Rotacoes.HasValue)
                            cmd.Parameters.AddWithValue("@Rotacoes", vinil.Rotacoes.Value);
                        else
                            cmd.Parameters.AddWithValue("@Rotacoes", DBNull.Value);

                        // Check for null before setting the parameter value
                        if (vinil.Tipo == null)
                            cmd.Parameters.AddWithValue("@Tipo", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@Tipo", vinil.Tipo);

                        // Check for null before setting the parameter value
                        if (vinil.Gravadora == null)
                            cmd.Parameters.AddWithValue("@Gravadora", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@Gravadora", vinil.Gravadora);

                        // Check for null before setting the parameter value
                        if (vinil.EdicaoEspecial.HasValue)
                            cmd.Parameters.AddWithValue("@Edicao_especial", vinil.EdicaoEspecial.Value);
                        else
                            cmd.Parameters.AddWithValue("@Edicao_especial", DBNull.Value);

                        // Check for null before setting the parameter value
                        if (vinil.Remasterizado.HasValue)
                            cmd.Parameters.AddWithValue("@Remasterizado", vinil.Remasterizado.Value);
                        else
                            cmd.Parameters.AddWithValue("@Remasterizado", DBNull.Value);

                        // Check for null before setting the parameter value
                        if (vinil.FotosVinil == null)
                            cmd.Parameters.AddWithValue("@Fotos_vinil", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@Fotos_vinil", vinil.FotosVinil);

                        // Only one that is never null
                        cmd.Parameters.AddWithValue("@Cliente", vinil.Cliente);

                        // Check for null before setting the parameter value
                        if (vinil.Leilao.HasValue)
                            cmd.Parameters.AddWithValue("@Leilao", vinil.Leilao.Value);
                        else
                            cmd.Parameters.AddWithValue("@Leilao", DBNull.Value);

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


        public void UpdateVinil(int idVinil, Vinil vinil)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Vinil SET Artista = @Artista, Album = @Album, AnoLancamento = @AnoLancamento, Condicao_disco = @Condicao_disco, Condicao_capa = @Condicao_capa, Categoria = @Categoria, Duracao = @Duracao, Tamanho = @Tamanho, Rotacoes = @Rotacoes, Tipo = @Tipo, Gravadora = @Gravadora, Edicao_especial = @Edicao_especial, Remasterizado = @Remasterizado, Fotos_vinil = @Fotos_vinil, Cliente = @Cliente, Leilao = @Leilao WHERE idVinil = @idVinil";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@idVinil", idVinil);

                        // Check for null before setting the parameter value
                        if (vinil.Artista == null)
                            cmd.Parameters.AddWithValue("@Artista", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@Artista", vinil.Artista);

                        // Check for null before setting the parameter value
                        if (vinil.Album == null)
                            cmd.Parameters.AddWithValue("@Album", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@Album", vinil.Album);

                        // Check for null before setting the parameter value
                        if (vinil.AnoLancamento.HasValue)
                            cmd.Parameters.AddWithValue("@AnoLancamento", vinil.AnoLancamento.Value);
                        else
                            cmd.Parameters.AddWithValue("@AnoLancamento", DBNull.Value);

                        // Check for null before setting the parameter value
                        if (vinil.CondicaoDisco.HasValue)
                            cmd.Parameters.AddWithValue("@Condicao_disco", vinil.CondicaoDisco.Value);
                        else
                            cmd.Parameters.AddWithValue("@Condicao_disco", DBNull.Value);

                        // Check for null before setting the parameter value
                        if (vinil.CondicaoCapa.HasValue)
                            cmd.Parameters.AddWithValue("@Condicao_capa", vinil.CondicaoCapa.Value);
                        else
                            cmd.Parameters.AddWithValue("@Condicao_capa", DBNull.Value);

                        // Check for null before setting the parameter value
                        if (vinil.Categoria == null)
                            cmd.Parameters.AddWithValue("@Categoria", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@Categoria", vinil.Categoria);

                        // Check for null before setting the parameter value
                        if (vinil.Duracao.HasValue)
                            cmd.Parameters.AddWithValue("@Duracao", vinil.Duracao.Value);
                        else
                            cmd.Parameters.AddWithValue("@Duracao", DBNull.Value);

                        // Check for null before setting the parameter value
                        if (vinil.Tamanho.HasValue)
                            cmd.Parameters.AddWithValue("@Tamanho", vinil.Tamanho.Value);
                        else
                            cmd.Parameters.AddWithValue("@Tamanho", DBNull.Value);

                        // Check for null before setting the parameter value
                        if (vinil.Rotacoes.HasValue)
                            cmd.Parameters.AddWithValue("@Rotacoes", vinil.Rotacoes.Value);
                        else
                            cmd.Parameters.AddWithValue("@Rotacoes", DBNull.Value);

                        // Check for null before setting the parameter value
                        if (vinil.Tipo == null)
                            cmd.Parameters.AddWithValue("@Tipo", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@Tipo", vinil.Tipo);

                        // Check for null before setting the parameter value
                        if (vinil.Gravadora == null)
                            cmd.Parameters.AddWithValue("@Gravadora", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@Gravadora", vinil.Gravadora);

                        // Check for null before setting the parameter value
                        if (vinil.EdicaoEspecial.HasValue)
                            cmd.Parameters.AddWithValue("@Edicao_especial", vinil.EdicaoEspecial.Value);
                        else
                            cmd.Parameters.AddWithValue("@Edicao_especial", DBNull.Value);

                        // Check for null before setting the parameter value
                        if (vinil.Remasterizado.HasValue)
                            cmd.Parameters.AddWithValue("@Remasterizado", vinil.Remasterizado.Value);
                        else
                            cmd.Parameters.AddWithValue("@Remasterizado", DBNull.Value);

                        // Check for null before setting the parameter value
                        if (vinil.FotosVinil == null)
                            cmd.Parameters.AddWithValue("@Fotos_vinil", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@Fotos_vinil", vinil.FotosVinil);

                        // Only one that is never null
                        cmd.Parameters.AddWithValue("@Cliente", vinil.Cliente);

                        // Check for null before setting the parameter value
                        if (vinil.Leilao.HasValue)
                            cmd.Parameters.AddWithValue("@Leilao", vinil.Leilao.Value);
                        else
                            cmd.Parameters.AddWithValue("@Leilao", DBNull.Value);

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

        public void DeleteVinil(int idVinil)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Vinil WHERE idVinil = @idVinil";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@idVinil", idVinil);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        public Vinil GetVinilById(int idVinil)
        {
            Vinil vinil = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Vinil WHERE idVinil = @idVinil";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@idVinil", idVinil);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            vinil = readVinis(reader).FirstOrDefault();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                // Handle the exception as needed
            }
            return vinil;
        }

        public List<Vinil> GetVinisByLeilao(int idLeilao)
        {
            List<Vinil> vinis = new List<Vinil>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Vinil WHERE Leilao = @idLeilao";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@idLeilao", idLeilao);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            vinis = readVinis(reader);
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
            return vinis;
        }
        private List<Vinil> readVinis(SqlDataReader reader)
        {
            List<Vinil> vinis = new List<Vinil>();
            Vinil vinil = null;
            while (reader.Read())
            {
                // Access data using reader
                int id = reader.GetInt32(reader.GetOrdinal("idVinil"));
                string artista = reader.IsDBNull(reader.GetOrdinal("Artista")) ? null : reader.GetString(reader.GetOrdinal("Artista"));
                string album = reader.IsDBNull(reader.GetOrdinal("Album")) ? null : reader.GetString(reader.GetOrdinal("Album"));
                DateTime? anoLancamento = reader.IsDBNull(reader.GetOrdinal("AnoLancamento")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("AnoLancamento"));
                int? condicaoDisco = reader.IsDBNull(reader.GetOrdinal("Condicao_disco")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("Condicao_disco"));
                int? condicaoCapa = reader.IsDBNull(reader.GetOrdinal("Condicao_capa")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("Condicao_capa"));
                string categoria = reader.IsDBNull(reader.GetOrdinal("Categoria")) ? null : reader.GetString(reader.GetOrdinal("Categoria"));
                int? duracao = reader.IsDBNull(reader.GetOrdinal("Duracao")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("Duracao"));
                int? tamanho = reader.IsDBNull(reader.GetOrdinal("Tamanho")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("Tamanho"));
                int? rotacoes = reader.IsDBNull(reader.GetOrdinal("Rotacoes")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("Rotacoes"));
                string tipo = reader.IsDBNull(reader.GetOrdinal("Tipo")) ? null : reader.GetString(reader.GetOrdinal("Tipo"));
                string gravadora = reader.IsDBNull(reader.GetOrdinal("Gravadora")) ? null : reader.GetString(reader.GetOrdinal("Gravadora"));

                bool? edicaoEspecial = null;
                // Check if the value is null in the database
                if (!reader.IsDBNull(reader.GetOrdinal("Edicao_especial")))
                {
                    // Read the byte value from the database
                    byte edicaoEspecialByte = reader.GetByte(reader.GetOrdinal("Edicao_especial"));

                    // Convert to bool
                    edicaoEspecial = (edicaoEspecialByte != 0);
                }

                bool? remasterizado = null;
                // Check if the value is null in the database
                if (!reader.IsDBNull(reader.GetOrdinal("Remasterizado")))
                {
                    // Read the byte value from the database
                    byte remasterizadoByte = reader.GetByte(reader.GetOrdinal("Remasterizado"));

                    // Convert to bool
                    remasterizado = (remasterizadoByte != 0);
                }

                string fotosVinil = reader.IsDBNull(reader.GetOrdinal("Fotos_vinil")) ? null : reader.GetString(reader.GetOrdinal("Fotos_vinil"));
                int cliente = reader.GetInt32(reader.GetOrdinal("Cliente"));
                int? leilao;
                int leilaoOrdinal = reader.GetOrdinal("Leilao");
                if (!reader.IsDBNull(leilaoOrdinal))
                {
                    leilao = reader.GetInt32(leilaoOrdinal);
                }
                else
                {
                    leilao = null;
                }
                vinil = new Vinil(id, artista, album, anoLancamento, condicaoDisco, condicaoCapa, categoria, duracao, tamanho, rotacoes, tipo, gravadora, edicaoEspecial, remasterizado, fotosVinil, cliente, leilao);
                Console.WriteLine($"Id: {id}, Artista: {artista}, Album: {album}, AnoLancamento: {anoLancamento}, CondicaoDisco: {condicaoDisco}, CondicaoCapa: {condicaoCapa}, Categoria: {categoria}, Duracao: {duracao}, Tamanho: {tamanho}, Rotacoes: {rotacoes}, Tipo: {tipo}, Gravadora: {gravadora}, EdicaoEspecial: {edicaoEspecial}, Remasterizado: {remasterizado}, FotosVinil: {fotosVinil}, Cliente: {cliente}, Leilao: {leilao}");
                vinis.Add(vinil);
            }
            return vinis;
        }
    }

    
}