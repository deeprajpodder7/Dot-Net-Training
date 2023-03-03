//using System.Data.SqlClient;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp3
//{
//    class SqlCommandDemo
//    {
//        SqlConnection conn;

//        public SqlCommandDemo()
//        {
//            //instantiate the connection
//            conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = Northwind; Integrated Security = SSPI");

//        }

//        //call methods that demo SqlCommand Capabilities
//        //static void Main()
//        //{
//        //    SqlCommandDemo scd = new SqlCommandDemo();

//        //    Console.WriteLine();
//        //    Console.WriteLine("Categories before in insert");
//        //    Console.WriteLine("--------------------------");

//        //    //use ExecuteReader method
//        //    scd.ReadData();

//        //    //use ExecuteNonQuery method for Insert
//        //    scd.Insertdata();
//        //    Console.WriteLine();
//        //    Console.WriteLine("Categories after insert");
//        //    Console.WriteLine("--------------------------");

//        //    scd.ReadData();

//        //    //use ExecuteNonQuery method for Update
//        //    scd.Updatedata();
//        //    Console.WriteLine();
//        //    Console.WriteLine("Categories after update");
//        //    Console.WriteLine("--------------------------");
//        //    scd.ReadData();

//        //    //use ExecuteNonQuery method for Delete
//        //    scd.Deletedata();
//        //    Console.WriteLine();
//        //    Console.WriteLine("Categories after delete");
//        //    Console.WriteLine("--------------------------");
//        //    scd.ReadData();


//        //    //use ExecuteScalar method
//        //    int numberOfRecords = scd.GetNumberOfRecords();
//        //    Console.WriteLine();
//        //    Console.WriteLine("Number of Records: " + numberOfRecords);

//        //}

//        //use ExecuteReader method

//        public void ReadData()
//        {
//            SqlDataReader rdr = null;
//            try
//            {
//                //2.Open the Conncetion
//                conn.Open();
//                SqlCommand cmd = new SqlCommand("select CategoryName from Categories", conn);

//                //4.Use Connection

//                //get query results
//                rdr = cmd.ExecuteReader();

//                //print first column of each record
//                while (rdr.Read())
//                {
//                    Console.WriteLine(rdr[0]);
//                }
//            }
//            finally
//            {
//                //close the reader
//                if (rdr != null)
//                {
//                    rdr.Close();
//                }

//                //close the connection
//                if (conn != null)
//                {
//                    conn.Close();
//                }
//            }
//        }

//        public void Insertdata()
//        {
//            try
//            {
//                conn.Open();
//                string insertString = @"insert into Categories(CategoryName,Description) values('Miscellaneous','Whatever doesnt fit elsewhere')";
//                SqlCommand cmd = new SqlCommand(insertString, conn);
//                cmd.ExecuteNonQuery();
//            }

//            finally
//            {
//                //close the connection
//                if (conn != null)
//                {
//                    conn.Close();
//                }
//            }
//        }

//        public void Updatedata()
//        {
//            try
//            {
//                conn.Open();
//                string updateString = @"UPDATE Categories SET CategoryName='Other' WHERE CategoryName='Miscellaneous'";
//                SqlCommand cmd = new SqlCommand(updateString);
//                cmd.Connection = conn;
//                cmd.ExecuteNonQuery();
//            }

//            finally
//            {
//                //close the connection
//                if (conn != null)
//                {
//                    conn.Close();
//                }
//            }
//        }

//        public void Deletedata()
//        {
//            try
//            {
//                conn.Open();
//                string deleteString = @"DELETE from Categories WHERE CategoryName='Other'";
//                SqlCommand cmd = new SqlCommand();
//                cmd.CommandText = deleteString;
//                cmd.Connection = conn;
//                cmd.ExecuteNonQuery();
//            }

//            finally
//            {
//                //close the connection
//                if (conn != null)
//                {
//                    conn.Close();
//                }
//            }
//        }

//        public int GetNumberOfRecords()
//        {
//            int count = -1;
//            try
//            {
//                conn.Open();
//                SqlCommand cmd = new SqlCommand("select count(*) from Categories", conn);
//                count = (int)cmd.ExecuteScalar();

//            }

//            finally
//            {
//                //close the connection
//                if (conn != null)
//                {
//                    conn.Close();
//                }
//            }
//            return count;

//        }
//    }
//}
