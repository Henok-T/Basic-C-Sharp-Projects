using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjMetho_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("please enter a number:");
            int num1 = int.Parse(Console.ReadLine());

            MathWorkOut operation = new MathWorkOut();
            Console.WriteLine("\n\t" + num1 + " +" + " my secret number 25 gives us: " + operation.Sum(num1));
            Console.WriteLine("\n\t" + num1 + " *" + " my secret number 25 gives us: " + operation.Product(num1));
            Console.WriteLine("\n\t" + num1 + " /" + " my secret number 25 gives us: " + operation.Quotient(num1));

            Console.ReadLine();
        }
    }
}
