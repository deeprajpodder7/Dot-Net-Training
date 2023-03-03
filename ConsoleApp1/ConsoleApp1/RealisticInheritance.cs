using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class RegularPolygon
    {
        public void calculatePerimeter(int length,int sides) {
            int result = length * sides;
            Console.WriteLine("Perimeter: "+result);
        }
    }

    class Square : RegularPolygon { 
    public int length=200;
        public int sides = 4;
        public void calculateArea() {
            int area = length * length;
            Console.WriteLine("Area of Square: " + area);
        }
    }

    class Recatangle : RegularPolygon {
        public int length = 100;
        public int breadth = 200;
        public int sides = 4;
        public void calculateArea()
        {
            int area = length * breadth;
            Console.WriteLine("Area of rectangle: " + area);
        }
    }

    public class RealisticInheritance
    {
        //public static void Main() { 
        //Square s1=new Square();
        //    s1.calculateArea();
        //    s1.calculatePerimeter(s1.length, s1.sides);

        //Recatangle t1= new Recatangle();
        //    t1.calculateArea();
        //    t1.calculatePerimeter(t1.length,t1.sides);
        //}
    }
}
