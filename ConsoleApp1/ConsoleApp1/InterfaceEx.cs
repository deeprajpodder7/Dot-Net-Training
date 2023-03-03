using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces

{
    // Interface
    interface IAnimal
    {
        void animalSound(); // interface method (does not have a body)
    }

    interface ITerrestrial
    {
        void Terrestrial(); // interface method (does not have a body)
    }

    // Pig "implements" the IAnimal interface
    class Dog : IAnimal,ITerrestrial
    {
        public void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The dog says: bhow bhow");
        }

        public void Terrestrial() {
            Console.WriteLine("The dog lives on Land");
        }
    }

    internal class InterfaceEx
    {
        //static void Main(string[] args)
        //{
        //    Dog myDog = new Dog();  // Create a Pig object
        //    myDog.animalSound();
        //    myDog.Terrestrial();
        //}
    }
}
