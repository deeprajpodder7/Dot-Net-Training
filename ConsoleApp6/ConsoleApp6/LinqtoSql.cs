using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
    {
   public class LinqtoSql
        {
        public static void Main(string[] args)
            {
            // Create a connection to the database
            var connectionString = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = College2; Integrated Security = SSPI";
            using var connection = new SqlConnection(connectionString);
            connection.Open();

            // Create a command to retrieve data from the database
            var command = new SqlCommand("SELECT * FROM Department", connection);

            // Retrieve data from the database
            using var reader = command.ExecuteReader();

            // Load the results into a list
            var departments = new List<Department>();
            while (reader.Read())
                {
                var department = new Department
                    {
                    department_id = reader.GetInt32(reader.GetOrdinal("department_id")),
                    department_name = reader.GetString(reader.GetOrdinal("department_name")),
                    location = reader.GetString(reader.GetOrdinal("location")),
                 
                    };
                departments.Add(department);
                }

            // Use LINQ to query the results
            var query = from d in departments select d;

            // Process the results
            foreach (var department in query)
                {
                Console.WriteLine($"Department_id: {department.department_id}, Department_name: {department.department_name}, Location: {department.location}");
                }

            }
            }
    }
