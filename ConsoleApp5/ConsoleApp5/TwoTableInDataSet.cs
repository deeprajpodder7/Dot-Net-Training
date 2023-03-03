using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp5
{
    public class TwoTableInDataSet
    {
        //static void Main(string[] args)
        //{
        //    //create a connnection string
        //    string connectionString = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = MyDb; Integrated Security = SSPI";

        //    DataSet dataSet = new DataSet(); //creating an instance of DataSet
            
        //    //data adapter to fill table 1
        //    SqlDataAdapter dataAdapter1 = null;

        //    //data adapter to fill table 2
        //    SqlDataAdapter dataAdapter2= null;
        //    try
        //    {
        //        //data adapter to fill table 1
        //        dataAdapter1 = new SqlDataAdapter("SELECT productID,name,description from Products", connectionString);
        //        dataAdapter1.Fill(dataSet,"Products");

        //        //data adapter to fill table 2
        //        dataAdapter2 = new SqlDataAdapter("SELECT productID,quantity from orderDetails", connectionString);
        //        dataAdapter2.Fill(dataSet,"orderDetails");

        //        //define a DataRelation object to connect two tables
        //        //DataColumn parentColumn = dataSet.Tables["Products"].Columns["productID"];
        //        //DataColumn childColumn = dataSet.Tables["orderDetails"].Columns["productID"];
        //        //DataRelation relation= new DataRelation("TableProducts_TableOrderDetails",parentColumn,childColumn);

        //        ////add DataRelation to dataset
        //        //dataSet.Relations.Add(relation);

        //        //foreach (DataRow row1 in dataSet.Tables["Products"].Rows) {
        //        //    Console.WriteLine("Table 1: Products");
        //        //    Console.WriteLine("productID: " + row1["productID"]);
        //        //    Console.WriteLine("name: " + row1["name"]);
        //        //    Console.WriteLine("description: " + row1["description"]);
        //        //    Console.WriteLine(" Related Rows in Table orderDetails :");
        //        //    foreach(DataRow row2 in row1.GetChildRows(relation))
        //        //    {
        //        //        Console.WriteLine(" Quantity: " + row2["quantity"]);
        //        //    }
        //        //}

        //        //read data from table Products
        //        Console.WriteLine("Table:Products:-");
        //        foreach(DataRow row in dataSet.Tables["Products"].Rows)
        //        {
        //            int id = (int)row["productID"];
        //            string name= (string)row["name"];
        //            string desc= (string)row["description"];
        //            Console.WriteLine($"productId:{id},name:{name},description:{desc}");
        //            Console.WriteLine();
        //        }

        //        //read data from table orderDetails
        //        Console.WriteLine("Table:orderDetails:-");
        //        foreach (DataRow row in dataSet.Tables["orderDetails"].Rows)
        //        {
        //            int id = (int)row["productID"];
        //            int quant = (int)row["quantity"];
               
        //            Console.WriteLine($"productId:{id},quantity:{quant}");
        //            Console.WriteLine();
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Error: " + ex.Message);
        //    }
        //    finally
        //    {

        //        dataAdapter1?.Dispose();
        //        dataAdapter2?.Dispose();//close the connection
        //    }
        //}
    }
}
