using Microsoft.Data.SqlClient;

using System;
using Microsoft.Data.SqlClient;

namespace Auto_Auction.DB
{
    public partial class Database
    {
        private static SqlConnection GetConnection()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
            {
                DataSource = "sql.itcn.dk",
                InitialCatalog = "mads64g6.SKOLE",
                UserID = "mads64g6.SKOLE",
                Password = "Bq6e22EaU3",
                TrustServerCertificate = true
            };

            return new SqlConnection(builder.ToString());
        }
        
        public static void TestConnection()
        {
            try
            {
                using var connection = GetConnection();
                connection.Open();
                Console.WriteLine("Connected!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($" Failed: {ex.Message}");
            }
        }
    }
}