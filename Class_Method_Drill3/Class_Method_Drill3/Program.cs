using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Drill3
{
    class Program
    {
        static void Main(string[] args)
        {
            //takes an int ==> returns an int
            MathsExercise mathAddition = new MathsExercise();
            Console.WriteLine("\n\t"+ mathAddition.Sum(12));

            //takes a decimal ==> returns an int
            MathsExercise mathsMultiply = new MathsExercise();
            Console.WriteLine("\n\t" + mathsMultiply.Sum(12.5m));

            //takes a string ==> returns an int
            MathsExercise mathsDivide = new MathsExercise();
            Console.WriteLine("\n\t" + mathsDivide.Sum("12"));

            

            Console.ReadLine();
        }
    }
}
