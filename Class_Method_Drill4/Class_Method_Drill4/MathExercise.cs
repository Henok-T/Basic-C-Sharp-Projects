using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Drill4
{
    class MathExercise
    {
        public int Multiply(int x, int optionalint = 20)
        {
            return Convert.ToInt32(x * 2 * optionalint);
        }
    }
}
