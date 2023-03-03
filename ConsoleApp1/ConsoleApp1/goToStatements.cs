using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class goToStatements
    {
        public void goTo() {
            int val = 2;
            switch (val)
            {
                case 1:
                    Console.WriteLine("is");
                    goto default;
                case 2:
                    Console.WriteLine("My");
                    goto case 3;
                    
                case 3:
                    Console.WriteLine("name");
                    goto case 1;
                default:
                    Console.WriteLine("Deepraj");
                    break;
            }
        }
    }
}
