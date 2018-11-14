using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main()
        {

            Employee employee = new Employee();
            employee.Quit();

            IQuittable emIqt = new Employee();
            emIqt.Quit();
            Console.ReadLine();
        }
    }
}
