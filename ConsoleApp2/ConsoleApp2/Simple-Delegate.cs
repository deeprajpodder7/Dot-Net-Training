using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    //define a custom delegate that has a string paramter and returns void
    delegate void CustomDelegate(string s);
  
    public class Simple_Delegate
    {

        //define two methods that have  the same signature as CustomDelegate
        static void Hello(string s)
        {

            Console.WriteLine($" Hello, {s}!");
        }

        static void Goodbye(string s)
        {

            Console.WriteLine($" Goodbye, {s}!");
        }

        //static void Main(string[] args)
        //{

        //    //declare instances of the custom delegate
        //    CustomDelegate HiDelegate,ByeDelegate,MultiCastDelegate,MultiMinusHiDelegate;

        //    HiDelegate = Hello;
        //    ByeDelegate = Goodbye;
        //    MultiCastDelegate=HiDelegate+Goodbye;
        //    MultiMinusHiDelegate = MultiCastDelegate - HiDelegate;

        //    Console.WriteLine("Invoking Delegate HiDelegate:");
        //    HiDelegate("D");
        //    Console.WriteLine("Invoking Delegate ByeDelegate:");
        //    ByeDelegate("Dbye");
        //    Console.WriteLine("Invoking Delegate MultiCastDelegate:");
        //    MultiCastDelegate("DMulti");

        //}
    }
}
