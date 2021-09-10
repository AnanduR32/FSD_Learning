using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise
{
    class Company
    {
        static void Main(string[] args)
        {
            FullTimeEmployee fteEmployee = new FullTimeEmployee();
            PartTimeEmployee pteEmployee = new PartTimeEmployee();
            fteEmployee.setDetails("102A", "Anandu R", "anandu.r@gmail.com", 0123456789);
            pteEmployee.setDetails("102B", "Anandu R", "anandu.r@gmail.in", 1234567890);
            fteEmployee.setSalary(700000.00f);
            pteEmployee.setSalary(480000.00f);
            fteEmployee.DisplayName();
            pteEmployee.DisplayName();
            Console.ReadKey();
        }
    }
    class Employee
    {
        protected string id;
        protected string fullName;
        protected string email;
        protected int phoneNo;
        protected Employee() {
            Console.Write("Employee - ");
        }
        protected void DisplayName()
        {
            Console.WriteLine("{0} {1} ", id, fullName);
        }
        public void setDetails(string id, string fullName, string email, int phoneNo)
        {
            this.id = id;
            this.fullName = fullName;
            this.email = email;
            this.phoneNo = phoneNo;
        }
    }
    class FullTimeEmployee : Employee
    {
        private float salary;

        public FullTimeEmployee()
        {
            Console.WriteLine("Type: Full-time");
        }
        public new void DisplayName()
        {
            Console.WriteLine("{0} {1} {2}", id, fullName, salary);
        }
        public void setSalary(float salary)
        {
            this.salary = salary;
        }
    }
    class PartTimeEmployee : Employee
    {
        private float salary;

        public PartTimeEmployee()
        {
            Console.WriteLine("Type: Part-time");
        }

        public new void DisplayName()
        {
            Console.WriteLine("{0} {1} {2} ", id, fullName, salary);
        }

        public void setSalary(float salary)
        {
            this.salary = salary;
        }
    }
}
