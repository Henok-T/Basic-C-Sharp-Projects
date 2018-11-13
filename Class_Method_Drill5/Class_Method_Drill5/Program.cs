using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Drill5
{
    class Program
    {
        static void Main()

        {
            Console.WriteLine("Please enter a number: ");
            int num1 = int.Parse(Console.ReadLine());

            MathsOpr mathDivd = new MathsOpr();
            mathDivd.Sum(num1);

            // overloaded method
            int a = 2;
            int b = 10;
            int c = 20;
            Console.WriteLine("========================This is an example of an overloaded method!");
            mathDivd.Sum(a, b, c);

            //method with output params
            int x = 10;
            int y = 5;
            Console.WriteLine("=========================This is an example of a method with output params!");
            mathDivd.Product(out x, out y);

            // example of a static class
            MyStatic.MethodStatico();
            Console.ReadLine();
        }   
    }
}
