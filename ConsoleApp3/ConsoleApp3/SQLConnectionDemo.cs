using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp3
{
    internal class SQLConnectionDemo
    {

        //static void Main(string[] args)
        //{
        //    //1.Instantiate the connection
        //    SqlConnection conn = new SqlConnection(
        //        "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=SSPI");
        //    SqlDataReader rdr = null;
        //    try
        //    {
        //        //2.Open the Conncetion
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand("select * from Customers", conn);

        //        //4.Use Connection

        //        //get query results
        //        rdr= cmd.ExecuteReader();

        //        //print first column of each record
        //        while(rdr.Read())
        //        {
        //            Console.WriteLine(rdr[0]);
        //        }
        //    }
        //    finally
        //    {
        //        //close the reader
        //        if(rdr != null)
        //        {
        //            rdr.Close();
        //        }

        //        //close the connection
        //        if(conn!=null)
        //        {
        //            conn.Close();
        //        }
        //    }
        
        //}
    }
}
