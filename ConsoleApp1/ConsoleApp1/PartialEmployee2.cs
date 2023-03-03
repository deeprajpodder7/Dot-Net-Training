using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PartialEmployee2
    {
    }

    public partial class Employee3 {
        public void getFirstName() {
            Console.WriteLine("First Name: " + firstName);
        } 
        public void getLastName() {
            Console.WriteLine("Last Name: " + lastName);
        }
    }
}
