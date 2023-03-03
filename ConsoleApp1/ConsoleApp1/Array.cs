using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Array
    {
        //public static void main(string[] args)
        //{
        //    int[] arr1;

        //    arr1 = new int[5];
        //    arr1[0] = 10;
        //    arr1[1] = 20;
        //    arr1[2] = 30;   
        //    foreach(int i in arr1)
        //    {
        //        Console.WriteLine(i);   
        //    }
        //    int j = 0;
            
        //    while(j < arr1.Length)
        //    {
        //        Console.WriteLine(" "+arr1[j]);
        //        j++;
        //    }

        //}

        public void arraySort() {
            int temp = 0;
            int[] arr2 = { 5, 2, 3, 7, 1, 9, 8 };
            for (int i = 0; i < arr2.Length-1; i++)
            {
                for(int j=i+1;j<arr2.Length;j++){
                    if (arr2[i] > arr2[j]) {
                        temp = arr2[i];
                        arr2[i] = arr2[j];
                        arr2[j] = temp;
                    }
                
                }
            }
            Console.WriteLine("Array sort in asscending order");
            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
