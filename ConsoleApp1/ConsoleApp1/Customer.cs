using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long phno { get; set; }
    }
    class CustomerOperations
    {
        List<Customer> customers;
        public CustomerOperations()
        {
            customers = new List<Customer>();
        }
        public void AddCustomer(Customer cust)
        {
            customers.Add(cust);
        }
        public List<Customer> GetCustomers()
        {
            return customers;
        }
        public void removeCustomers(int id)
        {

            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].CustomerId == id)
                {
                    customers.RemoveAt(i);
                }
            }

        }
    }
    class customerprogram
    {
        //static void Main(string[] args)
        //{
        //    CustomerOperations customerOperations = new CustomerOperations();
        //    customerOperations.AddCustomer(new Customer()
        //    { CustomerId = 1, FirstName = "John", LastName = "Cena", phno = 9999999999 });
        //    customerOperations.AddCustomer(new Customer()
        //    { CustomerId = 2, FirstName = "Rahul", LastName = "Sharma", phno = 111177777900 });
        //    foreach (var customer in customerOperations.GetCustomers())
        //    {
        //        Console.WriteLine(customer.CustomerId);
        //        Console.WriteLine(customer.FirstName);
        //        Console.WriteLine(customer.LastName);
        //        Console.WriteLine(customer.phno);
        //    }
        //    Console.WriteLine("Enter Customer ID to be removed: ");
        //    int k = Convert.ToInt32(Console.ReadLine());
        //    customerOperations.removeCustomers(k);
        //    Console.WriteLine("After removing: ");
        //    foreach (var customer in customerOperations.GetCustomers())
        //    {
        //        Console.WriteLine(customer.CustomerId);
        //        Console.WriteLine(customer.FirstName);
        //        Console.WriteLine(customer.LastName);
        //        Console.WriteLine(customer.phno);
        //    }

        //}   
    }
}
