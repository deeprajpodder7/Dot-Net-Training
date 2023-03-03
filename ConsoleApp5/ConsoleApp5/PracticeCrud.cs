using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ConsoleApp5
{
    public class PracticeCrud
    {
        SqlConnection conn;

        public PracticeCrud()
        {
            //instantiate the connection
            conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = MyDb; Integrated Security = SSPI");

        }

        //call methods that demo SqlCommand Capabilities
        //static void Main()
        //{
        //    PracticeCrud pc = new PracticeCrud();

        //    Console.WriteLine();
        //    Console.WriteLine("Datas before insert");
        //    Console.WriteLine("--------------------------");

        //    //use ExecuteReader method
        //    pc.ReadData();

        //    //use ExecuteNonQuery method for Insert
        //    //pc.Insertdata();
        //    Console.WriteLine();
        //    Console.WriteLine("Datas after inserting new record");
        //    Console.WriteLine("--------------------------");

        //    pc.ReadData();

        //    //use ExecuteNonQuery method for Update
        //    pc.Updatedata();
        //    Console.WriteLine();
        //    Console.WriteLine("Datas after updating a record");
        //    Console.WriteLine("--------------------------");
        //    pc.ReadData();

        //    Console.WriteLine("Stored Procedure:");
        //    Console.WriteLine("-------------------") ;
        //    pc.StoredProc();

        //    //use ExecuteNonQuery method for Delete
        //    //pc.Deletedata();
        //    //Console.WriteLine();
        //    //Console.WriteLine("Categories after deleting a record");
        //    //Console.WriteLine("--------------------------");
        //    //pc.ReadData();


        //    //use ExecuteScalar method
        //    int numberOfRecords = pc.GetNumberOfRecords();
        //    Console.WriteLine();
        //    Console.WriteLine("Number of Records: " + numberOfRecords);



        //}



        public void ReadData()
        {
            SqlDataReader rdr = null;
            try
            {
                //2.Open the Conncetion
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from Products", conn);

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

        public void Insertdata()
        {
            try
            {
                conn.Open();
                string insertString = @"insert into Products(productID,name,description,unitPrice) values(090,'PS5','Gaming Console',65000)";
                SqlCommand cmd = new SqlCommand(insertString, conn);
                cmd.ExecuteNonQuery();
            }

            finally
            {
                //close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public void Updatedata()
        {
            try
            {
                conn.Open();
                string updateString = @"UPDATE Products SET productID='050' WHERE name='PS5'";
                SqlCommand cmd = new SqlCommand(updateString);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
            }

            finally
            {
                //close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        //public void Deletedata()
        //{
        //    try
        //    {
        //        conn.Open();
        //        string deleteString = @"DELETE from users WHERE id='3'";
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandText = deleteString;
        //        cmd.Connection = conn;
        //        cmd.ExecuteNonQuery();
        //    }

        //    finally
        //    {
        //        //close the connection
        //        if (conn != null)
        //        {
        //            conn.Close();
        //        }
        //    }
        //}

        public int GetNumberOfRecords()
        {
            int count;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select count(*) from Products", conn);
                count = (int)cmd.ExecuteScalar();

            }

            finally
            {
                //close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return count;

        }


        public void StoredProc()
        {
            SqlDataReader rdr = null;
            //try
            //{
            //2.Open the Conncetion
            conn.Open();
            SqlCommand cmd = new SqlCommand("getProductByOrderID", conn);


            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@orderid", "1");
            //4.Use Connection

            //get query results

            rdr = cmd.ExecuteReader();

            //print first column of each record
            while (rdr.Read())
            {
                for (int i = 0; i < rdr.FieldCount; i++)
                {
                    Console.WriteLine(rdr[i] + " ");
                }
                Console.WriteLine();

            }
            rdr.Close();
            conn.Close();
        }
    }
       
    }



