using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //public class Animal {
    //    public virtual void eat() {
    //        Console.WriteLine("I eat food");
    //    }
    //}
    //public class Dog2 : Animal
    //{
    //    public override void eat()
    //    {
    //        Console.WriteLine("I eat dog food");

    //    }
    //}

    public class Loan {
        public virtual void calculateLoan() {
            Console.WriteLine("This is Loan");
        }
    }
    public class PersonalLoan:Loan {
        public override void calculateLoan()
        {
            Console.WriteLine("I am Personal Loan");
        }
    }
    public class EducationLoan : Loan
    {
        public override void calculateLoan()
        {
            Console.WriteLine("I am Education Loan");
        }
    }
    public class HomeLoan : Loan
    {
        public override void calculateLoan()
        {
            base.calculateLoan();
            Console.WriteLine("I am Home Loan");
        }
    }
    public class MethodRide
    {
        //public static void Main()
        //{
        //    //Animal max = new Dog2();
        //    //max.eat();
        //    Loan l=new HomeLoan();
        //    l.calculateLoan();
            
        //}
    }
}
