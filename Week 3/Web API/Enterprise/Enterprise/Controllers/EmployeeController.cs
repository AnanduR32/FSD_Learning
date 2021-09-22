using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Enterprise.Models;

namespace Enterprise.Controllers
{
    public class EmployeeController : ApiController
    {
        private static List<Employee> Employees = new List<Employee>
        {
            new Employee() { Id = 1, Name = "Anandu R", Email = "ananduraj32@gmail.com", Mobile = 7012835996 }
        };


        [HttpGet]
        public List<Employee> Get()
        {
            return Employees;
        }
        [HttpPost]
        public string Post(Employee emp)
        {
            emp.Id = Employees.Count() + 1;
            Employees.Add(emp);
            return emp.Name + " successfully added!";
        }

        [HttpPut]
        public string Put(Employee emp)
        {
            foreach(Employee employee in Employees){
                if(employee.Id == emp.Id)
                {
                    employee.Name = emp.Name;
                    employee.Mobile = emp.Mobile;
                    employee.Email = emp.Email;
                    break;
                }
            }
            return "Employee with id " + emp.Id + " successfully modified";
        }

        [HttpDelete]
        public string Delete(Employee emp)
        {
            Employees.Remove(Employees.FirstOrDefault<Employee>(employee => employee.Id == emp.Id));
            return "Delete employee record with id " + emp.Id;
        }
    }
}