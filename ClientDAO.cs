using System;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;


// adicionar este nugget pra não dar erro Microsoft.Data.SqlClient
// mudar o DESKTOP-AQDL94R em "Data Source=DESKTOP-AQDL94R;Initial Catalog=VinilDB;Integrated Security=True;TrustServerCertificate=True;" para o vosso servername;


namespace SpinToWin
{
    internal class ClientDAO
    {
        private static string connectionString = "Data Source=DESKTOP-AQDL94R;Initial Catalog=VinilDB;Integrated Security=True;TrustServerCertificate=True;";

        public List<Client> GetListClients()
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
                            client = new Client(email, pass, dinheiro);
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


        public int InsertClient(Client client)
        {
            int insertedId = -1; // Default value if insertion fails

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Cliente (Email, Pass, Dinheiro) OUTPUT INSERTED.idCliente VALUES (@Email, @Pass, @Dinheiro)";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Email", client.Email);
                        cmd.Parameters.AddWithValue("@Pass", client.Pass);
                        cmd.Parameters.AddWithValue("@Dinheiro", client.Dinheiro);

                        // Execute the query and get the inserted id
                        insertedId = (int)cmd.ExecuteScalar();
                        MessageBox.Show($"Inserted id: {insertedId}");
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


        //fazer update pelo email
        public void UpdateClient(Client client)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Cliente SET Email = @Email, Pass = @Pass, Dinheiro = @Dinheiro WHERE Email = @Email";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Email", client.Email);
                        cmd.Parameters.AddWithValue("@Pass", client.Pass);
                        cmd.Parameters.AddWithValue("@Dinheiro", client.Dinheiro);
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                // Handle the exception as needed
            }
        }


        //Atenção: este dele só funca se cliente não tiver vinis nem leilões
        public void DeleteClient(string email)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Cliente WHERE Email = @Email";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                // Handle the exception as needed
            }
        }

        //Getclient by email
        public Client GetClientByEmail(string email)
        {
            Client client = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Cliente WHERE Email = @Email";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Access data using reader
                                int id = reader.GetInt32(reader.GetOrdinal("idCliente"));
                                string pass = reader.GetString(reader.GetOrdinal("Pass"));
                                double dinheiro = reader.GetDouble(reader.GetOrdinal("Dinheiro"));

                                // Use the retrieved data as needed
                                Console.WriteLine($"ID: {id}, Email: {email}, Pass: {pass}, Dinheiro: {dinheiro}");
                                client = new Client(email, pass, dinheiro);
                            }
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
            return client;
        }

        //Getclient by id
        public Client GetClientbyID(int id)
        {
            Client client = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Cliente WHERE idCliente = @idCliente";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@idCliente", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Access data using reader
                                string email = reader.GetString(reader.GetOrdinal("Email"));
                                string pass = reader.GetString(reader.GetOrdinal("Pass"));
                                double dinheiro = reader.GetDouble(reader.GetOrdinal("Dinheiro"));

                                // Use the retrieved data as needed
                                Console.WriteLine($"ID: {id}, Email: {email}, Pass: {pass}, Dinheiro: {dinheiro}");
                                client = new Client(email, pass, dinheiro);
                            }
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
            return client;
        }
    }
}
