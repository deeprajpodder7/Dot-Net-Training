using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance

{
    // base class
    class Animal
    {
        protected void eat()
        {
            Console.WriteLine("I can eat and I am from Animal Class");
        }
    }

    // derived class of Animal 
    class Dog : Animal
    {
        //static void Main(string[] args)
        //{

        //    Dog labrador = new Dog();

        //    // access protected method from base class
        //    labrador.eat();

        //    Console.ReadLine();
        //}
    }
    internal class AnimalInheritance
    {
    }
}
