using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Drill4
{
    class Program
    {
        static void Main(string[] args)
        {
            MathExercise mathMultiply = new MathExercise();
            Console.WriteLine("Please enter two numbers one at a time.");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\t" + a + " x" + " 2" + " x"+ " the given value of b => " + b + " is equal to " + mathMultiply.Multiply(a, b));
            Console.WriteLine("\n\t" + a + " x" + " 2" + " x" + " the optional value of b => 20 " + " is equal to " + mathMultiply.Multiply(a));
            Console.ReadLine();

        }



        
    }
}
