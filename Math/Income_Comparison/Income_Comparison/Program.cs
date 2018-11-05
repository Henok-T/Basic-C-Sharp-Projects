using System;

namespace Income_Comparison
{
    class Program
    {
        static void Main()
        {
            //Person1
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate");
            int hrRate1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Hours worked per week");
            int hrPerWeek1 = Int32.Parse(Console.ReadLine());

            //Person2
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate");
            int hrRate2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Hours worked per week");
            int hrPerWeek2 = Int32.Parse(Console.ReadLine());

            // Annual salaries
            int annualpay1 = hrRate1 * hrPerWeek1 * 52;
            Console.WriteLine("Annual salary for Person 1 is " + annualpay1);
            int annualpay2 = hrRate2 * hrPerWeek2 * 52;
            Console.WriteLine("Weekly salary for Person 1 is " + annualpay2);

            //The comparison
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool compare_Income = annualpay1 > annualpay2;
            Console.WriteLine(compare_Income.ToString());

            // wait for me to read
            Console.Read();
        }
    }
}
