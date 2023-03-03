using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Exception
    {
        static string a = null;
        public static void excep(string a) {
            if (a==null) {
                throw new NullReferenceException("This is an Exception!!");
            }
        }

        //public static void Main(string[] args)
        //{
        //    try {   
        //        excep(a);
        //    }
        //    catch(System.Exception e) {
        //    Console.WriteLine(e.ToString);
        //    }   
        //}
    }
}
