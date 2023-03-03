using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FNLN
    {
        public void fnln() {
            string fName, lName;
            Console.WriteLine("Enter your first name: ");
            fName = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            lName = Console.ReadLine();
            Console.WriteLine("Before: " + fName + " " + lName);
            Console.WriteLine("After: {0} {1}", lName, fName);
        }
    }
}
