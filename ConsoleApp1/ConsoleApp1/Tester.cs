using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Box {
        private double length;
        private double breadth;
        private double height;
        public double getVolume() {
            return length * breadth * height;
        }

        public void setLength(double len) {
            length = len;
        }
        public void setBreadth(double bre) {
            breadth = bre;
        }
        public void setHeight(double hei) {
            height = hei;
        }

        public static Box operator +(Box b,Box c) {
        Box box= new Box();
            box.length=b.length+ c.length;
            box.breadth=b.breadth+ c.breadth;
            box.height=b.height+ c.height;  
            return box;
        }
    }
    public class Tester
    {
        //public static void Main()
        //{
        //    Box box1= new Box();
        //    Box box2= new Box();
        //    Box box3= new Box();
        //    double volume = 0.0;

        //    box1.setLength(7.0);
        //    box1.setBreadth(5.0);
        //    box1.setHeight(3.0);
        //    box2.setLength(12.0);
        //    box2.setBreadth(13.0);
        //    box2.setHeight(10.0);
        //    volume = box1.getVolume();
        //    Console.WriteLine("Volume of box1: " + volume);

        //    volume=box2.getVolume();
        //    Console.WriteLine("Volume of box2: " + volume);

        //    box3 = box1 + box2;
        //    volume=box3.getVolume();
        //    Console.WriteLine("Volume of box3: "+volume);

        //}
    }
}
