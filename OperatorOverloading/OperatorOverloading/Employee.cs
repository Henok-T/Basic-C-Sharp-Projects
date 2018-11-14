using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Employee
    {
        public int Id { get; set; }

        public static bool operator ==(Employee employee_X, Employee employee_Y)
        {
            return employee_X.Id == employee_Y.Id;
        }

        public static bool operator !=(Employee employee_X, Employee employee_Y)
        {
            return employee_X.Id != employee_Y.Id;
        }
    }
}
