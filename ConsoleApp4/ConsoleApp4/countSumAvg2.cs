using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class countSumAvg2
    {
        static void Main()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = Northwind; Integrated Security = SSPI";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("select COUNT(ProductID),SUM(UnitsInStock),AVG(UnitPrice),MAX(UnitPrice),MIN(UnitPrice) from Products", con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            int count = reader.GetInt32(0);
                            int sum = reader.GetInt32(1);
                            decimal average = reader.GetDecimal(2);
                            decimal maxUnit=reader.GetDecimal(3);
                            decimal minUnit=reader.GetDecimal(4);

                            Console.WriteLine("Count:{0}, Sum:{1}, Average:{2}, Max:{3}, Min:{4}", count, sum, average,maxUnit,minUnit);
                        }
                        reader.Close();
                    }
                }
            }
        }

    }
}
