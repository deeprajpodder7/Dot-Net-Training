using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Instead of defining two methods that should do the same thing, it is better to overload one.

    //In the example below, we overload the PlusMethod method to work for both int and double:
    internal class OverloadingEx
    {
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }

        //static void Main(string[] args)
        //{
        //    int myNum1 = PlusMethod(8, 5);
        //    double myNum2 = PlusMethod(4.3, 6.26);
        //    Console.WriteLine("Int: " + myNum1);
        //    Console.WriteLine("Double: " + myNum2);
        //}
    }
}
