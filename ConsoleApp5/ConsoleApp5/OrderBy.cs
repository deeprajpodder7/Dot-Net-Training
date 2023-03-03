using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class OrderBy
    {
        SqlConnection conn;

        public OrderBy()
        {
            //instantiate the connection
            conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = MyDb; Integrated Security = SSPI");

        }

        //call methods that demo SqlCommand Capabilities
        //static void Main()
        //{
        //    OrderBy pc = new OrderBy();

        //    Console.WriteLine();
        //    Console.WriteLine("Datas Using Order By:");
        //    Console.WriteLine("--------------------------");

        //    //use ExecuteReader method
        //    pc.ReadData();

           
        //}



        public void ReadData()
        {
            SqlDataReader rdr = null;
            try
            {
                //2.Open the Conncetion
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from Products order by UnitPrice asc", conn);

                //4.Use Connection

                //get query results
                rdr = cmd.ExecuteReader();

                //print first column of each record
                while (rdr.Read())
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", rdr[0], rdr[1], rdr[2], rdr[3]);
                }
            }
            finally
            {
                //close the reader
                if (rdr != null)
                {
                    rdr.Close();
                }

                //close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
