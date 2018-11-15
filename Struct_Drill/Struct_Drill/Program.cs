using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Drill
{
    class Program
    {

        public struct Number
        {
            public decimal Amount { get; set; }
        }
        static void Main(string[] args)
        {
            Number num = new Number();
            num.Amount = 10.101m;
            Console.WriteLine("\n\t The Amount assigned to the \"Struct Number\" is "+ num.Amount);
            Console.ReadLine();
        }
    }
}
