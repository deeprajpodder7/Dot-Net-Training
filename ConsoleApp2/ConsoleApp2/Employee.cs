using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int Age { get; set; }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Employee[] EmployeeArray = { new Employee() { EmployeeId = 1,EmployeeName="John",Age=21},
    //        new Employee() { EmployeeId = 2,EmployeeName="Deep",Age=23},
    //        new Employee() { EmployeeId = 3,EmployeeName="Raj",Age=28},
    //        new Employee() { EmployeeId = 4,EmployeeName="Ron",Age=32}
    //        };
    //        Employee[] Employees = new Employee[10];
    //        int i = 0;

    //        foreach(Employee employee in EmployeeArray)
    //        {
    //            if (employee.Age > 22 && employee.Age < 30) {
    //                Employees[i]= employee;
    //                System.Console.WriteLine(employee.EmployeeName); i++;
    //            }
    //        }
    //    }
    //}

    class Program12
    {
        //static void Main(string[] args)
        //{
        //    Employee[] employeeArray = { new Employee() { EmployeeId = 1,EmployeeName="John",Age=21},
        //    new Employee() { EmployeeId = 2,EmployeeName="Deep",Age=23},
        //    new Employee() { EmployeeId = 3,EmployeeName="Raj",Age=28},
        //    new Employee() { EmployeeId = 4,EmployeeName="Ron",Age=32}
        //    };

        //    //use LINQ to find teenage Employees
        //    Employee[] middleageEmployees = employeeArray.Where(s=>s.Age>22 && s.Age<30).ToArray();

        //    //use LINQ to find first employee whose name is Ron
        //    Employee ron = employeeArray.Where(s => s.EmployeeName == "Ron").FirstOrDefault();

        //    //use LINQ to find first employee whose Employee ID is 4
        //    Employee id4 = employeeArray.Where(s => s.EmployeeId == 4).FirstOrDefault();

        //}
    }

}
