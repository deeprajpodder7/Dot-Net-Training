using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PassByReference
    {
        static void Increment(ref int i) { 
            i=i+1;
        } 
        //static void Main(string[] args)
        //{
        //    int x = 1;
        //    Increment(ref x);
        //    Console.WriteLine(x);

        //}
    }
}
