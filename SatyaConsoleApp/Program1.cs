using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatyaConsoleApp
{
    class Program1
    {
        public void TestFunction()
        {
            Employee employee = new Employee();
            employee.GetSalary(100, "Kalyan");
            employee.GetSalary(1001, "FirstName", "LastName");
        }
    }
}
