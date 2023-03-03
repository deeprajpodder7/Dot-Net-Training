using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class ReadFromCustomers
    { 

        //call methods that demo SqlCommand Capabilities
        //static void Main()
        //{  
        //    string connectionString = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = Northwind; Integrated Security = SSPI";
        //    using (SqlConnection con = new SqlConnection(connectionString))
        //    {
        //        con.Open();
        //        using (SqlCommand command = new SqlCommand("select CompanyName,ContactName from Customers",con)) { 
        //        using(SqlDataReader reader = command.ExecuteReader())
        //            {
        //                Console.WriteLine("CompanyName\t\t\t\tContactName");
        //                Console.WriteLine("--------------------------------------------------------------");
        //                while (reader.Read())
        //                {
        //                    string compName = reader[0].ToString();
        //                    string contName = reader[1].ToString();
        //                   Console.WriteLine(compName.PadRight(40)+contName);
        //                }
        //            }
        //        }
        //    }
        //}

       
    }
}
