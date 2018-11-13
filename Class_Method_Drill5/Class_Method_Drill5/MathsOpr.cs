using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Drill5
{
    public class MathsOpr
    {
        public void Sum(int num1) { Console.WriteLine("Your number divided by \"2\" is equal to "+ (num1 / 2) + "\n"); }

        // overloading a method
        public void Sum(int a, int b, int c) { Console.WriteLine("\n  2 x 10 + 20 = " + (a * b + c) + "\n");}

        //method with output parameters
        public  void  Product(out int x, out int y)
        {
            x = 10;
            y = 5;
            Console.WriteLine("\n 10 x 5 = " + (x * y));
        }
    }
}
