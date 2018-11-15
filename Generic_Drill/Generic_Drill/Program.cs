using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Drill
{
    class Program
    {
        public static void Main()
        {
            Employee<string> em1 = new Employee<string>
            { things = new List<string> { "DOB", "DOE", "Zip-Code", "Salary-Range", "Years Employed", "No.Promotions" }};
            foreach (string thing in em1.things){Console.WriteLine("\t" + thing +"\n");}

            Employee<int> em2 = new Employee<int>{things = new List<int>
            { 1960, 2000, 97200, 70000 - 12000, 5 }};
            foreach (int thing in em2.things){Console.WriteLine("\t" + thing + "\n");}

            Console.ReadLine();
        }
    }
}
