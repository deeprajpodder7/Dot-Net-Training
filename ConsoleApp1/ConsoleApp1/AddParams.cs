using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AddParams
    {
        public static int Add(params int[] ListNumbers) {
            int total = 0;
            foreach (int i in ListNumbers)
            {
                total += i;
            }
            return total;
        }
        //public static void Main(String[] args) {
        //    int y = Add(10,20,45,69,96);
        //    Console.WriteLine(y);
        //}
    }
}
