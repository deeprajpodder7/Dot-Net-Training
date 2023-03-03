using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ConsoleApp4
{
    public class OtherDbCrud
    {
        SqlConnection conn;

        public OtherDbCrud()
        {
            //instantiate the connection
            conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = Office; Integrated Security = SSPI");

        }

        //call methods that demo SqlCommand Capabilities
        //static void Main()
        //{
        //    OtherDbCrud odc = new OtherDbCrud();

        //    Console.WriteLine();
        //    Console.WriteLine("Datas before insert");
        //    Console.WriteLine("--------------------------");

        //    //use ExecuteReader method
        //    odc.ReadData();

        //    //use ExecuteNonQuery method for Insert
        //    odc.Insertdata();
        //    Console.WriteLine();
        //    Console.WriteLine("Datas after inserting new record");
        //    Console.WriteLine("--------------------------");

        //    odc.ReadData();

        //    //use ExecuteNonQuery method for Update
        //    odc.Updatedata();
        //    Console.WriteLine();
        //    Console.WriteLine("Datas after updating a record");
        //    Console.WriteLine("--------------------------");
        //    odc.ReadData();

        //    //use ExecuteNonQuery method for Delete
        //    odc.Deletedata();
        //    Console.WriteLine();
        //    Console.WriteLine("Categories after deleting a record");
        //    Console.WriteLine("--------------------------");
        //    odc.ReadData();


        //    //use ExecuteScalar method
        //    int numberOfRecords = odc.GetNumberOfRecords();
        //    Console.WriteLine();
        //    Console.WriteLine("Number of Records: " + numberOfRecords);

        //    odc.StoredProc();

        //}

        //use ExecuteReader method

        public void ReadData()
        {
            SqlDataReader rdr = null;
            try
            {
                //2.Open the Conncetion
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from users", conn);

                //4.Use Connection

                //get query results
                rdr = cmd.ExecuteReader();

                //print first column of each record
                while (rdr.Read())
                {
                    Console.WriteLine("{0}\t{1}\t{2}", rdr[0], rdr[1], rdr[3]);
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
                string insertString = @"insert into users(id,full_name,enabled,last_login) values(9,'Rohan Sarkar','t','2020-09-19')";
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
                string updateString = @"UPDATE users SET full_name='Other' WHERE id='1'";
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

        public void Deletedata()
        {
            try
            {
                conn.Open();
                string deleteString = @"DELETE from users WHERE id='3'";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = deleteString;
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

        public int GetNumberOfRecords()
        {
            int count = -1;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select count(*) from users", conn);
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
                SqlCommand cmd = new SqlCommand("getBooksCountByUsername", conn);


                cmd.CommandType=System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserName","Jane Smith");
                //4.Use Connection

                //get query results
               
            rdr= cmd.ExecuteReader();

            //print first column of each record
            while (rdr.Read())
            {
                for(int i= 0;i< rdr.FieldCount; i++) { 
                    Console.WriteLine(rdr[i] + " ");
                }
              Console.WriteLine();

            }
        }
            //finally
            //{
            //    //close the reader
            //    if (rdr != null)
            //    {
            //        rdr.Close();
            //    }

            //    //close the connection
            //    if (conn != null)
            //    {
            //        conn.Close();
            //    }
            //}
        }
    }


