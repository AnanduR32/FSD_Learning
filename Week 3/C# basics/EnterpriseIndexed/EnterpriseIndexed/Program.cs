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
        }
    }

    class EmployeeData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Mobile { get; set; }
        public int Age { get; set; }
    }

    class Employees
    {
        private List<EmployeeData> EmployeesRecord;
        Employees()
        {
            EmployeesRecord = new List<EmployeeData>();
            EmployeesRecord.Add(new EmployeeData() { Id = 1, Age = 23, Name="Anandu R" });
        }
        public EmployeeData this[int id]
        {
            get
            {
                return 
            };
        }
    }
}
