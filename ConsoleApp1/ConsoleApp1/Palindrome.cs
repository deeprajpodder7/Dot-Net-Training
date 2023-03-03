using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Palindrome
    {
        public void palindrome()
        {
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();
            Console.WriteLine("The original string is: " + str);
            int length = str.Length - 1;
            string rev = "";
            while (length >= 0)
            {
                rev += str[length];
                length--;
            }
            Console.WriteLine("Reversed String is: " + rev);
            bool result = String.Equals(str,rev);
            if (result) {
                Console.WriteLine("Palindrome");

            }
            else { Console.WriteLine("Not Palindrome"); }
        }
    }
}