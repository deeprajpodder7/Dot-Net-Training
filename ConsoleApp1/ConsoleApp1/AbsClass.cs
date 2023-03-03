using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class AbsClass
    {
        public int AddTwoNums(int Num1,int Num2)
        {
            return Num1 + Num2;
        }

        public abstract int MultiplyTwoNums(int Num1, int Num2) ;
    }

    class AbsDerived : AbsClass { 
    public override int MultiplyTwoNums(int Num1, int Num2) { 
        return Num1 * Num2;
        }

        //static void Main(string[] args)
        //{
        //    AbsDerived calculate=new AbsDerived();
        //    int added=calculate.AddTwoNums(15,25);
        //    int multiplied=calculate.MultiplyTwoNums(15,25);
        //    Console.WriteLine("Added: {0} Multiplied: {1}", added, multiplied);
        //}
    }
}
