using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseCollectionTypesafe
{
    public class EmployeeData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public long Mobile { get; set; }
        public int Age { get; set; }
    }

    partial class Employees
    {
        public EmployeeData this[int id]
        {
            get
            {
                return EmployeesRecord.FirstOrDefault(employee => employee.Id == id);
            }
            set
            {
                EmployeesRecord.FirstOrDefault(employee => employee.Id == id).Id = value.Id;
                EmployeesRecord.FirstOrDefault(employee => employee.Id == id).Name = value.Name;
                EmployeesRecord.FirstOrDefault(employee => employee.Id == id).Gender = value.Gender;
                EmployeesRecord.FirstOrDefault(employee => employee.Id == id).Mobile = value.Mobile;
            }
        }
        public List<EmployeeData> this[string query]
        {
            get
            {
                if (query == "employee list")
                {
                    return this.EmployeesRecord;
                }
                else
                {
                    return null;
                }
            }
           
        }

    }
}
