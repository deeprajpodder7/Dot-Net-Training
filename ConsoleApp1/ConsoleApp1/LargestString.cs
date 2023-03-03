using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class LargestString
    {

        public static String largestString(params String[] listString)
        {
        String maxLength = "";
            for (int i = 0; i < listString.Length; i++) {
                if (listString[i].Length > maxLength.Length)
                {
                    maxLength = listString[i];
                }
            }
            return maxLength;
            }
        //public static void Main(String[] args)
        //{
        //   String z= largestString("abc","qwerty","abcdefg");
        //  Console.WriteLine(z);
        //}
    }
}
