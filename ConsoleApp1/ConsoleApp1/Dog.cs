using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Dog
    {
        String name, breed;
        int age;
        public Dog(String name, String breed, int age)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
        }
        public String getName()
        {
            return name;
        }
        public int getAge()
        {
            return age;
        }
        public String getBreed()
        {
            return breed;
        }
        public String toString()
        {
            return ("Hi I am " + this.getName + "My breed and age is: " + this.getBreed + " ," + this.getAge);
        }

        //public static void Main(String[] args) {
        //    Dog tuffy=new Dog("tuffy","pug",3);
        //    Console.WriteLine(tuffy.toString());
        //}
    }
}
