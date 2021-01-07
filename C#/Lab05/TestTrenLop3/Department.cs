using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTrenLop3
{
    class Employees
    {
        private int EmpId = 1;
        private string EmpName = "An Dink";
        private int age = 25;

        public virtual void Display()
        {
            Console.WriteLine("Employee ID: " + EmpId);
            Console.WriteLine("Employee Name: " + EmpName);
        }
    }

    class Department:Employees
    {
        private int DepId = 501;
        private string DepName = "Sales";

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Department ID: " + DepId);
            Console.WriteLine("Department Name: " + DepName);
        }
        static void Main(string[] args)
        {
            Employees objEmployees = new Department();
            objEmployees.Display();
        }
    }
}
