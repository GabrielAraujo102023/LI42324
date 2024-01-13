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
                            int? condicaoDisco = reader.GetInt32(reader.GetOrdinal("CondicaoDisco"));
                            int? condicaoCapa = reader.GetInt32(reader.GetOrdinal("CondicaoCapa"));
                            string categoria = reader.GetString(reader.GetOrdinal("Categoria"));
                            int? duracao = reader.GetInt32(reader.GetOrdinal("Duracao"));
                            int? tamanho = reader.GetInt32(reader.GetOrdinal("Tamanho"));
                            int? rotacoes = reader.GetInt32(reader.GetOrdinal("Rotacoes"));
                            string tipo = reader.GetString(reader.GetOrdinal("Tipo"));
                            string gravadora = reader.GetString(reader.GetOrdinal("Gravadora"));
                            bool? edicaoEspecial = reader.GetBoolean(reader.GetOrdinal("EdicaoEspecial"));
                            bool? remasterizado = reader.GetBoolean(reader.GetOrdinal("Remasterizado"));
                            string fotosVinil = reader.GetString(reader.GetOrdinal("FotosVinil"));
                            int cliente = reader.GetInt32(reader.GetOrdinal("Cliente"));
                            int? leilao = reader.GetInt32(reader.GetOrdinal("Leilao"));

                            // Use the retrieved data as needed
                            Console.WriteLine($"Artista: {artista}, Album: {album}, AnoLancamento: {anoLancamento}, CondicaoDisco: {condicaoDisco}, CondicaoCapa: {condicaoCapa}, Categoria: {categoria}, Duracao: {duracao}, Tamanho: {tamanho}, Rotacoes: {rotacoes}, Tipo: {tipo}, Gravadora: {gravadora}, EdicaoEspecial: {edicaoEspecial}, Remasterizado: {remasterizado}, FotosVinil: {fotosVinil}, Cliente: {cliente}, Leilao: {leilao}");
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