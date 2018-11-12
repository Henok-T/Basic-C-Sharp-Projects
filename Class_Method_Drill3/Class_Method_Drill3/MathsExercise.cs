using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Drill3
{
    class MathsExercise
    {
        public int Sum(int num1)
        {
            return num1 + 12;
        }

        public decimal Sum(decimal num1)
        {
            return Convert.ToInt32(num1 * 2);
        }

        public int Sum(string num1)
        {
            int num2 = Convert.ToInt32(num1);
            return num2 / 2;
        }

    }
}
