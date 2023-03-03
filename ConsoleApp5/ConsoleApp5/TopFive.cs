using System.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class TopFive
    {
        static void Main(string[] args)
        {
            // Set up connection string and query string
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = Northwind; Integrated Security = SSPI";
            string queryString = "SELECT TOP 5 * FROM Products ORDER BY UnitPrice DESC";

            SqlDataReader reader = null;
            // Set up connection and command objects
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                // Open connection and execute query
                connection.Open();
                reader=command.ExecuteReader();

                // Iterate through results and print them out
                while (reader.Read())
                {
                    Console.WriteLine("{0}\t\t\t{1}\t\t\t{2}", reader.GetInt32(0), reader.GetString(1), reader.GetDecimal(5));
                }

                // Close reader and connection
                reader.Close();
                connection.Close();
            }
        }
    }
}
