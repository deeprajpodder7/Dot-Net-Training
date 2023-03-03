using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Language
    {

        // abstract method
       public abstract void method1();

        // regular method
        public void method2()
        {
            Console.WriteLine("This is regular method");
        }
    }

    class ABC:Language { 
        public override void method1() { Console.WriteLine("This is method1 overridden"); }
    }
    internal class AbstractClassEx
    {
        //public static void Main(string[] args) { 
        //    ABC abc= new ABC();
        //    abc.method1();
        //    abc.method2();
        //}
    }
}
