using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DepartmentInherit
    {
        String deptName,deptLoc;
        public DepartmentInherit(/*String deptName,String deptLoc*/) { 
            //this.deptName = deptName;
            //this.deptLoc = deptLoc;
        }
        public void getDepartmentName() {
            Console.WriteLine("The Dept name is :IT");
        }
        public void getDepartmentLocation() {
            Console.WriteLine("The Dept location is: Kolkata");
        }
    }
     class Employee:DepartmentInherit
    {
        public Employee() { }
        public void getEmployeeName() {
            Console.WriteLine("Deepraj");
        }
    }
}
