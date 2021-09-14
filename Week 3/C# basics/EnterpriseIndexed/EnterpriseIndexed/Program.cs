using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseIndexed
{
    class Enterprise
    {
        static void Main(string[] args)
        {
            Employees EnterpriseEmployee = new Employees();
            Console.WriteLine("{0} {1} {2} {3}",EnterpriseEmployee[1].Id, EnterpriseEmployee[1].Name, EnterpriseEmployee[1].Gender, EnterpriseEmployee[1].Mobile);
            EnterpriseEmployee[1].Name = "Aquaregis32";
            Console.WriteLine("{0} {1} {2} {3}", EnterpriseEmployee[1].Id, EnterpriseEmployee[1].Name, EnterpriseEmployee[1].Gender, EnterpriseEmployee[1].Mobile);
            Console.ReadKey();
        }
    }

    class EmployeeData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public long Mobile { get; set; }
        public int Age { get; set; }
    }

    class Employees
    {
        private List<EmployeeData> EmployeesRecord;
        public Employees()
        {
            EmployeesRecord = new List<EmployeeData>();
            EmployeesRecord.Add(new EmployeeData() { Id = 1, Age = 23, Name = "Anandu R", Gender = "Male", Mobile = 7012835996});
            EmployeesRecord.Add(new EmployeeData() { Id = 2, Age = 22, Name = "Aishwarya Michael", Gender = "Female", Mobile = 9876543210 });
            EmployeesRecord.Add(new EmployeeData() { Id = 3, Age = 21, Name = "S Nikhit", Gender = "Female", Mobile = 9876543211 });
            EmployeesRecord.Add(new EmployeeData() { Id = 4, Age = 22, Name = "Kennith Philips", Gender = "Male", Mobile = 9876543212 });
        }
        public EmployeeData this[int id]
        {
            get
            {
                return EmployeesRecord.FirstOrDefault(employee => employee.Id == id);
            }
            set
            {
                EmployeesRecord.FirstOrDefault(employee => employee.Id == id).Id= value.Id;
                EmployeesRecord.FirstOrDefault(employee => employee.Id == id).Name = value.Name;
                EmployeesRecord.FirstOrDefault(employee => employee.Id == id).Gender = value.Gender;
                EmployeesRecord.FirstOrDefault(employee => employee.Id == id).Mobile = value.Mobile;
            }
        }
        public string this[string gender]
        {
            get
            {
                return EmployeesRecord.Count(employee => employee.Gender == gender).ToString();
            }
        }
    }
}
