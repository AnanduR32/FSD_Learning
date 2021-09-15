using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseActionFuncPredicateDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(1, "Anandu R");
            Action<string> act = new Action<string>(emp.displayName);
            Func<int, double> fnc = new Func<int, double>(emp.getSalary);
            Predicate<string> prd = new Predicate<string>(emp.isName);
            act("SOTI");
            Console.WriteLine("Earns Rs.{0}",fnc(127));
            Console.WriteLine("Name? : {0}",prd("Anandu R"));
            Console.ReadKey();
        }

        
    }
    
    class Employee
    {
        private int _id;
        private string _name;
        public Employee(int id, string name)
        {
            this._id = id;
            this._name = name;
        }
        public int Id
        {
            get
            {
                return this._id;
            }
        }
        public string Name
        {
            get
            {
                return this._name;
            }
        }
        public double getSalary(int pswd)
        {
            if(pswd == 127)
            {
                return 1000.0;
            }
            else
            {
                return 0.0;
            }
        }
        public bool isName(string name)
        {
            if(name == this.Name)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void displayName(string Company)
        {
            Console.WriteLine("{0} works at {1}", this.Name, Company);
        }
    }
}
