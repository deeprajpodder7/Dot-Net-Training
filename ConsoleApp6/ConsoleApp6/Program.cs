using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Program
    {
        public static List<Employee> employees = new List<Employee>();
        public static List<Project> projects = new List<Project>();

        //public static void Main(string[] args)
        //{
        //    InitializeEmployees();
        //    InitializeProjects();

        //        //WHERE
        //        var querySyntax1 = from employee in employees where employee.EmployeeName.StartsWith("T") select employee.EmployeeName;
        //    Console.WriteLine("WHERE in querySyntax1------------");
        //    foreach (var item in querySyntax1) { 
        //        Console.WriteLine(item); 
        //    }
        //    Console.WriteLine('\n');

        //    var methodSyntax1 = employees.Where(e => e.EmployeeName.StartsWith("T"));
        //    Console.WriteLine("WHERE in methodSyntax1------------");
        //    foreach (var item in methodSyntax1)
        //    {
        //        Console.WriteLine(item.EmployeeName);    
        //    }
        //    Console.WriteLine('\n');


        //    //ORDER BY ASCENDING
        //    var querySyntax2=from employee in employees orderby employee.EmployeeName select employee.EmployeeName;

        //    var methodSyntax2=employees.OrderBy(e=>e.EmployeeName);

        //    Console.WriteLine("Order by ascending in querySyntax2------------");
        //    foreach (var item in querySyntax2)
        //        {
        //        Console.WriteLine(item);
        //        }
        //    Console.WriteLine('\n');

        //    Console.WriteLine("Order by ascending methodSyntax2------------");
        //    foreach (var item in methodSyntax2)
        //        {
        //        Console.WriteLine(item.EmployeeName);
        //        }
        //    Console.WriteLine('\n');


        //    //ORDER BY DESCENDING
        //    var querySyntax3 = from employee in employees orderby employee.EmployeeName descending select employee.EmployeeName;

        //    var methodSyntax3 = employees.OrderByDescending(e => e.EmployeeName);

        //    Console.WriteLine("Order by descending in querySyntax3------------");
        //    foreach (var item in querySyntax3)
        //        {
        //        Console.WriteLine(item);
        //        }
        //    Console.WriteLine('\n');

        //    Console.WriteLine("Order by descending methodSyntax3------------");
        //    foreach (var item in methodSyntax3)
        //        {
        //        Console.WriteLine(item.EmployeeName);
        //        }
        //    Console.WriteLine('\n');



        //    //THEN BY
        //    var querySyntax4 = from employee in employees orderby employee.ProjectId, employee.EmployeeName descending select employee;

        //    var methodSyntax4 = employees.OrderBy(e=>e.ProjectId).ThenByDescending(e => e.EmployeeName);

        //    Console.WriteLine("Then by in querySyntax4------------");
        //    foreach (var item in querySyntax4)
        //        {
        //        Console.WriteLine(item.EmployeeName+" : "+item.ProjectId);
        //        }
        //    Console.WriteLine('\n');

        //    Console.WriteLine("Then by descending methodSyntax4------------");
        //    foreach (var item in methodSyntax4)
        //        {
        //        Console.WriteLine(item.EmployeeName + " : " + item.ProjectId);
        //        }
        //    Console.WriteLine('\n');

        //    //TAKE
        //    var querySyntax5 = (from employee in employees select employee).Take(2);

        //    var methodSyntax5 = employees.Take(2);
           
        //    Console.WriteLine("Take in querySyntax5------------");
        //    foreach (var item in querySyntax5)
        //        {
        //        Console.WriteLine(item.EmployeeName);
        //        }
        //    Console.WriteLine('\n');


        //    Console.WriteLine("Take in methodSyntax5------------");
        //    foreach (var item in methodSyntax5)
        //        {
        //        Console.WriteLine(item.EmployeeName);
        //        }
        //    Console.WriteLine('\n');

        //    //SKIP
        //    var querySyntax6 = (from employee in employees select employee).Skip(2);

        //    var methodSyntax6 = employees.Skip(2);

        //    Console.WriteLine("Skip in querySyntax6------------");
        //    foreach (var item in querySyntax6)
        //        {
        //        Console.WriteLine(item.EmployeeName);
        //        }
        //    Console.WriteLine('\n');


        //    Console.WriteLine("Skip in methodSyntax6------------");
        //    foreach (var item in methodSyntax6)
        //        {
        //        Console.WriteLine(item.EmployeeName);
        //        }
        //    Console.WriteLine('\n');

        //    //GROUP 
        //    var querySyntax7 = from employee in employees group employee by employee.ProjectId;

        //    var methodSyntax7 = employees.GroupBy(employee => employee.ProjectId);

        //    Console.WriteLine("GROUP  in querySyntax7------------");
        //    foreach (var item in querySyntax7)
        //        {
        //        Console.WriteLine(item.Key+" : "+item.Count());
        //        }
        //    Console.WriteLine('\n');


        //    Console.WriteLine("GROUP  in methodSyntax7------------");
        //    foreach (var item in methodSyntax7)
        //        {
        //        Console.WriteLine(item.Key + " : " + item.Count());
        //        }
        //    Console.WriteLine('\n');


        //    //FIRST
        //    var querySyntax8=(from employee in employees select employee).First();

        //    var methodSyntax8= employees.First();

        //    Console.WriteLine("First in querySyntax8----------------");
        
        //        if (querySyntax8 != null)
        //            {
        //            Console.WriteLine(querySyntax8.EmployeeName);
        //            }

        //    Console.WriteLine();
        //    Console.WriteLine("First in methodSyntax8----------------");

        //        if (methodSyntax8 != null)
        //        {
        //        Console.WriteLine(methodSyntax8.EmployeeName);
        //        }
        //    Console.WriteLine();

        //    //JOIN
        //    var querySyntax9 = from employee in employees join project in projects on employee.ProjectId equals project.ProjectId select new { employee.EmployeeName, project.ProjectName };

        //    var methodSyntax9 = employees.Join(projects,
        //                                       e => e.ProjectId,
        //                                       p => p.ProjectId,
        //                                       (e, p) => new { e.EmployeeName, p.ProjectName });
        //    Console.WriteLine("join in querySyntax9---------------");
            
        //    foreach (var item in querySyntax9)
        //        {
        //        Console.WriteLine(item.EmployeeName + " : " + item.ProjectName);
        //        }

        //    Console.WriteLine();
        //    Console.WriteLine("join in querySyntax9---------------");

        //    foreach (var item in methodSyntax9)
        //        {
        //        Console.WriteLine(item.EmployeeName + " : "+item.ProjectName);
        //        }
        //    Console.WriteLine() ;


        //    //LEFT JOIN
        //    var querySyntax10 = from employee in employees join project in projects on employee.ProjectId equals project.ProjectId into group1
        //                        from project in group1.DefaultIfEmpty()
        //                        select new { employee.EmployeeName, ProjectName=project?.ProjectName??"NULL" };

        //    Console.WriteLine("Left join in querySyntax10---------------");

        //    foreach (var item in querySyntax10)
        //        {
        //        Console.WriteLine(item.EmployeeName + " : " + item.ProjectName);
        //        }

        //    Console.WriteLine();

        //    int[] numbersA = {0,2,4,5,6,8,9 };
        //    int[] numbersB = { 1, 3, 5, 7, 8 };

        //    var pairs = from a in numbersA from b in numbersB where a < b select new { a, b };
        //    Console.WriteLine("Pairs where a<b: ");
        //    foreach (var pair in pairs)
        //        {
        //        Console.WriteLine("{0} is less than {1}: ", pair.a, pair.b);
        //        }
            
        //    }
        



        public static void InitializeEmployees() {
            employees.Add(new Employee
            {
                EmployeeId = 1,
                EmployeeName = "Tuba",
                ProjectId = 100
            });

            employees.Add(new Employee
            {
                EmployeeId = 2,
                EmployeeName = "Atul",
                ProjectId = 101
            });

            employees.Add(new Employee
            {
                EmployeeId = 3,
                EmployeeName = "Theran",
                ProjectId = 101
            });
        }

        public static void InitializeProjects()
        {
            projects.Add(new Project
            {
                ProjectId=100,
                ProjectName="ABC"
            });

            projects.Add(new Project
            {
                ProjectId = 101,
                ProjectName = "PQR"
            });
        }
    }
}