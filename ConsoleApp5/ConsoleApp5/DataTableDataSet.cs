using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;

namespace ConsoleApp5
{
    public class DataTableDataSet
    {
        //static void Main(string[] args) {
        //    //create a connnection string
        //    string connectionString = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = MyDb; Integrated Security = SSPI";

        //    DataSet dataset = new DataSet(); //creating an instance of DataSet

        //    SqlDataAdapter dataAdapter = null;
        //    try
        //    {
        //        //Create a new instance of DataAdapter and pass in a connection string and SQL query to retrieve the data from the database
        //        string sqlQuery = "Select * from Products";

        //        dataAdapter = new SqlDataAdapter(sqlQuery, connectionString);

        //        //create instance of DataTable
        //        DataTable datatable = new DataTable();

        //        //use the DataAdapter to fill the DataTable with the data from the database
        //        dataAdapter.Fill(datatable);

        //        //add the DataTable to the DataSet
        //        dataset.Tables.Add(datatable);

        //        //loop through the rows and columns of the DataTable to display the data
        //        foreach (DataRow row in datatable.Rows)
        //        {
        //            foreach (DataColumn col in datatable.Columns)
        //            {
        //                Console.WriteLine("{0}={1}", col.ColumnName, row[col]);
        //            }
        //            Console.WriteLine("=====================================");
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Error: " + ex.Message);
        //    }
        //    finally {

        //        dataAdapter?.Dispose(); //close the connection
        //    }
        //}
    }
}
