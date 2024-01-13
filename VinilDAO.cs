using System;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;



namespace SpinToWin
{
    internal class VinilDAO
    {
        private static string connectionString = "Data Source=DESKTOP-AQDL94R;Initial Catalog=VinilDB;Integrated Security=True;TrustServerCertificate=True;";


        public List<Vinil> GetListVinis()
        {
            List<Vinil> vinis = new List<Vinil>();
            Vinil vinil = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Vinil";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Access data using reader
                            string artista = reader.GetString(reader.GetOrdinal("Artista"));
                            string album = reader.GetString(reader.GetOrdinal("Album"));
                            DateTime? anoLancamento = reader.GetDateTime(reader.GetOrdinal("AnoLancamento"));
                            int? condicaoDisco = reader.GetInt32(reader.GetOrdinal("Condicao_disco"));
                            int? condicaoCapa = reader.GetInt32(reader.GetOrdinal("Condicao_capa"));
                            string categoria = reader.GetString(reader.GetOrdinal("Categoria"));
                            int? duracao = reader.GetInt32(reader.GetOrdinal("Duracao"));
                            int? tamanho = reader.GetInt32(reader.GetOrdinal("Tamanho"));
                            int? rotacoes = reader.GetInt32(reader.GetOrdinal("Rotacoes"));
                            string tipo = reader.GetString(reader.GetOrdinal("Tipo"));
                            string gravadora = reader.GetString(reader.GetOrdinal("Gravadora"));
                            byte edicaoEspecialByte = reader.GetByte(reader.GetOrdinal("Edicao_especial"));
                            bool? edicaoEspecial = edicaoEspecialByte != 0;
                            byte remasterizadoByte = reader.GetByte(reader.GetOrdinal("Remasterizado"));
                            bool? remasterizado = remasterizadoByte != 0;
                            string fotosVinil = reader.GetString(reader.GetOrdinal("Fotos_vinil"));
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
                            vinil = new Vinil(artista, album, anoLancamento, condicaoDisco, condicaoCapa, categoria, duracao, tamanho, rotacoes, tipo, gravadora, edicaoEspecial, remasterizado, fotosVinil, cliente, leilao);
                            vinis.Add(vinil);
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
    }
}