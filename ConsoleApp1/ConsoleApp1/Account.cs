using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Account
    {
        public Account() { }
        public void getAccountID() {
            Console.WriteLine("Account ID: 001");
        }
        public void getAccountBalance() {
            Console.WriteLine("Account Balance: 2900.00");
        }
    }
     public class Customer:Account { 
        public Customer() { }
        public void getFName() {
            Console.WriteLine("First Name: Deepraj");
        }
        public void getLName() {
            Console.WriteLine("Last Name: Podder");
        }
    }
}
