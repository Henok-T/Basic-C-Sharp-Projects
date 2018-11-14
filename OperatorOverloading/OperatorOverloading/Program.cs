using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Program
    {
        static void Main()
        {

            Employee employee_X = new Employee();
            employee_X.Id = 1000;

            Employee employee_Y = new Employee();
            employee_Y.Id = 3000;

            Console.WriteLine(employee_X.Id == employee_Y.Id );
            Console.WriteLine(employee_X.Id != employee_Y.Id);

            Console.ReadLine();
        }
    }
}
