using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseSorting
{
    class Enterprise
    {
        static void Main(string[] args)
        {
            Employees EnterpriseEmployee = new Employees();
            Console.WriteLine("Old : \n{0} {1} {2} {3}", EnterpriseEmployee[1].Id, EnterpriseEmployee[1].Name, EnterpriseEmployee[1].Gender, EnterpriseEmployee[1].Mobile);
            EnterpriseEmployee[1].Name = "Aquaregis32";
            Console.WriteLine("New : \n{0} {1} {2} {3}\n", EnterpriseEmployee[1].Id, EnterpriseEmployee[1].Name, EnterpriseEmployee[1].Gender, EnterpriseEmployee[1].Mobile);

            EmployeeData testEmp = new EmployeeData() { Id = 1, Age = 23, Name = "Anandu R", Gender = "Male", Mobile = 7012835996 };


            Console.WriteLine("Employee List Originally");
            foreach (var emp in EnterpriseEmployee["employee list"])
            {
                Console.WriteLine("{0} {1} {2} {3}", emp.Id, emp.Name, emp.Age, emp.Mobile);
            }

            EnterpriseEmployee["employee list"].Sort();                          // in class hardcoded logic - sorts based on Id
            Console.WriteLine("\nEmployee List hard logic sorting based on employee id: ");
            foreach (var emp in EnterpriseEmployee["employee list"])
            {
                Console.WriteLine("{0} {1} {2} {3}", emp.Id, emp.Name, emp.Age, emp.Mobile);
            }

            EnterpriseEmployee["employee list"].Sort(new CompareByMobile());     // using comparer (interface implemented) class
            Console.WriteLine("\nEmployee List sorting based on employee mobile using comparer class: ");
            foreach (var emp in EnterpriseEmployee["employee list"])
            {
                Console.WriteLine("{0} {1} {2} {3}", emp.Id, emp.Name, emp.Age, emp.Mobile);
            }

            EnterpriseEmployee["employee list"].Sort(                            // using comparison delegate method
                new Comparison<EmployeeData>(
                    (emp1, emp2) =>
                    {
                        return emp1.Age.CompareTo(emp2.Age);
                    }
                    )
                ); 

            Console.WriteLine("\nEmployee List sorting based on employee age using comparison delegate method: ");
            foreach (var emp in EnterpriseEmployee["employee list"])
            {
                Console.WriteLine("{0} {1} {2} {3}", emp.Id, emp.Name, emp.Age, emp.Mobile);
            }



            Console.ReadKey();
        }
    }

    partial class Employees
    {
        private List<EmployeeData> EmployeesRecord;
        public Employees()
        {
            EmployeesRecord = new List<EmployeeData>();
            EmployeesRecord.Add(new EmployeeData() { Id = 1, Age = 23, Name = "Anandu R", Gender = "Male", Mobile = 7012835996 });
            EmployeesRecord.Add(new EmployeeData() { Id = 4, Age = 22, Name = "Kennith Philips", Gender = "Male", Mobile = 4876543212 });
            EmployeesRecord.Add(new EmployeeData() { Id = 2, Age = 22, Name = "Aishwarya Michael", Gender = "Female", Mobile = 9876542210 });
            EmployeesRecord.Add(new EmployeeData() { Id = 3, Age = 21, Name = "S Nikhit", Gender = "Female", Mobile = 9876143211 });
        }
    }
}
