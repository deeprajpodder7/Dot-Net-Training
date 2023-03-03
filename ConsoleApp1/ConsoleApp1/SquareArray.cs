using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SquareArray
    {
        public void squareArray() { 
        int[] arr1= { 1, 2, 3 };
            int[] arr2=new int[5];
            for(int i=0;i<3; i++){
                arr2[i] = arr1[i] * arr1[i];
            }
            Console.WriteLine(arr2);
                }
    }
}
