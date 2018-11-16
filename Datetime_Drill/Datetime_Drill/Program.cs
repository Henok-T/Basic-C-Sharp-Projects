using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime_Drill
{
    class Program
    {
        static void Main()
        {

            DateTime d = DateTime.Now;
            Console.WriteLine( "\n Right now it is  "+ d + ".");

            Console.WriteLine("\n Please enter a whole number.\n");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("\n In " + x + "hrs from now it will be " + d.AddHours(x) + ".");


            Console.ReadLine();
        }
    }
}
