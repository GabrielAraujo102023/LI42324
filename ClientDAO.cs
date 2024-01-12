using System;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;


// adicionar este nugget pra não dar erro Microsoft.Data.SqlClient

namespace SpinToWin
{
    internal class ClientDAO
    {
        private static string connectionString = "Data Source=DESKTOP-AQDL94R;Initial Catalog=VinilDB;Integrated Security=True;TrustServerCertificate=True;";
        public List<Client> clients = new List<Client>();

        public List<Client> GetClients()
        {
            List<Client> clients = new List<Client>();
            Client client = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Cliente";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Access data using reader
                            int id = reader.GetInt32(reader.GetOrdinal("idCliente"));
                            string email = reader.GetString(reader.GetOrdinal("Email"));
                            string pass = reader.GetString(reader.GetOrdinal("Pass"));
                            double dinheiro = reader.GetDouble(reader.GetOrdinal("Dinheiro"));

                            // Use the retrieved data as needed
                            Console.WriteLine($"ID: {id}, Email: {email}, Pass: {pass}, Dinheiro: {dinheiro}");
                            client = new Client(id, email, pass, dinheiro);
                            clients.Add(client);
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
            return clients;
        }

    }
}
