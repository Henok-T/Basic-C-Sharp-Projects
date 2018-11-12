using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Drill2
{
    class Program
    {
        static void Main(string[] args)
        {

            MathsExercise addition = new MathsExercise();

            int x = 200;
            int y = 800; 

            addition.Sum(200, 800);
            addition.Sum(num1: x, num2: y);

            Console.ReadLine();
        }
    }
}
