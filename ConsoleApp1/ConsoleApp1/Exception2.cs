using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Exception2
    {
        static int a = 12;
        public static void excep(int a)
        {
            if (a == 12)
            {
                throw new NullReferenceException("This is an forced null Exception!!");
            }
        }

        //public static void Main(string[] args)
        //{
        //    try
        //    {
        //        excep(a);
        //    }
        //    catch (System.Exception e)
        //    {
        //        Console.WriteLine(e.ToString);
        //    }
        //}
    }
}
