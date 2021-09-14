using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseDelegate
{
    public delegate bool IsPromotabeDelegate(EmployeeData employee);
    class Company
    {
        
        public static bool isPromotable(EmployeeData employee)
        {
            if(employee.Experience >= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            IsPromotabeDelegate ip = new IsPromotabeDelegate(isPromotable);
            employee.DisplayPromotable(ip);
            Console.ReadKey();
        }
    }
    class Employee
    {
        List<EmployeeData> EmployeeRecord = new List<EmployeeData>();
        public Employee()
        {
            EmployeeRecord.Add(new EmployeeData()
            {
                Id = 1,
                Name = "Anandu R",
                Experience = 3,
                Salary = 1600

            });
            EmployeeRecord.Add(new EmployeeData()
            {
                Id = 2,
                Name = "Aishwarya Michael",
                Experience = 3,
                Salary = 1400

            });
            EmployeeRecord.Add(new EmployeeData()
            {
                Id = 3,
                Name = "S Nikhit",
                Experience = 2,
                Salary = 1800

            });
            EmployeeRecord.Add(new EmployeeData()
            {
                Id = 4,
                Name = "Jiya George",
                Experience = 1,
                Salary = 1700

            });
        }

        public void DisplayPromotable(IsPromotabeDelegate ip)
        {
            foreach(EmployeeData employee in EmployeeRecord)
            {
                if (ip(employee))
                {
                    Console.WriteLine("{0} is promotable", employee.Name);
                }
            }
        }

        public EmployeeData this[int id]
        {
            get
            {
                return EmployeeRecord.FirstOrDefault(employee => employee.Id == id);
            }
        }

        
    }
    public class EmployeeData
    {
        private int _id;
        private string _name;
        private int _experience;
        private double _salary;
        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        public int Experience
        {
            get
            {
                return this._experience;
            }
            set
            {
                this._experience = value;
            }
        }
        public double Salary
        {
            get
            {
                return this._salary;
            }
            set
            {
                this._salary = value;
            }
        }
        
    }
}
