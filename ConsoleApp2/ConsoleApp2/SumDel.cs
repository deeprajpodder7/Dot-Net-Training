using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public delegate int SomeOperation(int x, int y);
    public class SumDel
    {
        public static int Sum(int a,int b) { return a + b; }
        //public static void Main(string[] args)
        //{
        //    SomeOperation add = Sum;

        //    int result = add(9, 8);

        //    Console.WriteLine(result);
        //}

    }
}
