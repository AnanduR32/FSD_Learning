using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Id = 1;
            employee.Name = "Anandu R";
            employee.Gender = "Male";
            Console.WriteLine("{0} {1} {2}", employee.Id, employee.Name, employee.Gender);
            Console.ReadKey();
        }
    }
    
}
