using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SplitNumber
    {
        public void splitNumber()
        {
            string str1 = "+919123721390";
            int length = str1.Length - 1;
            string str2 = "";
            int i = 0;
            while (i <= length)
            {
                
                if (i == 2)
                {
                    str2 = str2 + " ";
                }
                str2 += str1[i];
                i++;
            }
        }
    }
}