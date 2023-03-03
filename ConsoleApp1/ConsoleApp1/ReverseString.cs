using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ReverseString
    {
        public void reverseString() {
            string str = "Deep";
            Console.WriteLine("The original string is: "+str);
            int length=str.Length-1;
            string rev = "";
            while (length>=0) {
                rev += str[length];
                length--;
                    }
            Console.WriteLine("Reversed String is: " + rev);
        }      
    }
}
