using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatyaConsoleApp
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int GetSalary(int employeeId, string FirstName)
        {
            return 100;
        }

        public int GetSalary(int employeeId, string FirstName, string LastName)
        {
            return 1000;
        }
       
    }
}
