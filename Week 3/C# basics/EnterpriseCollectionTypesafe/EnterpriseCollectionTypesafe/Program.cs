using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseCollectionTypesafe
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

            foreach (var emp in EnterpriseEmployee["employee list"])
            {
                Console.WriteLine("{0} {1}", emp.Id, emp.Name);
            }

            Console.WriteLine("\nTest Employee: \n{0} {1} {2} {3} {4}", testEmp.Id, testEmp.Name, testEmp.Age, testEmp.Gender, testEmp.Mobile);

            Console.WriteLine("Whether test employee in employee records: {0}\n", EnterpriseEmployee["employee list"].Contains(testEmp));
            Console.WriteLine("Whether employee with name \"Aishwarya Michael\" exists in employee records: {0}\n", EnterpriseEmployee["employee list"].Exists(emp => emp.Name == "Aishwarya Michael"));


            Console.WriteLine("\nEmployees with id < 3 : ");
            foreach (var emp in EnterpriseEmployee["employee list"].FindAll(emp => emp.Id < 3))
            {
                Console.WriteLine("{0} {1}", emp.Id, emp.Name);
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
            EmployeesRecord.Add(new EmployeeData() { Id = 2, Age = 22, Name = "Aishwarya Michael", Gender = "Female", Mobile = 9876543210 });
            EmployeesRecord.Add(new EmployeeData() { Id = 3, Age = 21, Name = "S Nikhit", Gender = "Female", Mobile = 9876543211 });
            EmployeesRecord.Add(new EmployeeData() { Id = 4, Age = 22, Name = "Kennith Philips", Gender = "Male", Mobile = 9876543212 });
        }
    }
}
