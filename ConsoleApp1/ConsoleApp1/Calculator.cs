using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Calculator
    {
        public static double divide(int firstnum,int secondnum) {
           int div = firstnum / secondnum;
           return div;
   
        }
        public static int multiply(int firstnum, int secondnum)
        {
            int mult = firstnum * secondnum;
            return mult;

        }
        public static int add(int firstnum, int secondnum)
        {
            int add = firstnum + secondnum;
            return add;

        }
        public static int subtract(int firstnum, int secondnum)
        {
            int sub = firstnum - secondnum;
            return sub;

        }
        //public static void main(string[] args)
        //{
        //   add(1, 2);
        //    subtract(8,4);
        //    multiply(8, 4);
        //    divide(8, 4);
        //}
    }
    }
