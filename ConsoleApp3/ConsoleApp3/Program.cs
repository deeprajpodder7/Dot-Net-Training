using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
   public class Program
    {

        //static void Main(string[] args)
        //{
        //    string connectionString= "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;" +"Integrated Security=true";
        //    //provide query string with a parameter placeholder

        //    string queryString = "SELECT ProductID,UnitPrice,ProductName from dbo.products WHERE UnitPrice>@pricePoint ORDER BY UnitPrice DESC;";

        //    //specify the parameter value
        //    int paramValue = 5;

        //    //create and open a connection in using block.This ensures that all resources will be closed
        //    //and disposed when the code exits.

        //    using(SqlConnection connection = new SqlConnection(connectionString)) { 
        //    //create the command and the parameter object
        //    SqlCommand command=new SqlCommand(queryString, connection);
        //        command.Parameters.AddWithValue("@pricePoint", paramValue);

        //        try
        //        {
        //            connection.Open();
        //            SqlDataReader reader = command.ExecuteReader();
        //            while(reader.Read())
        //            {
        //                Console.WriteLine("\t{0}\t{1}\t{2}", reader[0], reader[1], reader[2]);
        //            }
        //            reader.Close();
        //        }

        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.Message);  

        //        }
        //    }

        //}
    }
}
