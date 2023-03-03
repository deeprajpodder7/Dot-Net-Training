using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StaticConstructor
    {
        static StaticConstructor() {
            Console.WriteLine("Static Constructor");
        }
        public StaticConstructor(int i) {
            Console.WriteLine("Instance Constructor "+i);
        }
        public string ProgramDetails(String name,int id) { return "Name: " + name + "ID :" + id; }
        //public static void Main(String[] args)
        //{
        //    StaticConstructor obj1= new StaticConstructor(1);
        //    Console.WriteLine(obj1.ProgramDetails("First Execution",1));
        //    StaticConstructor obj2 = new StaticConstructor(2);
        //    Console.WriteLine(obj2.ProgramDetails("Second Execution", 2));
        //}
    }
}
