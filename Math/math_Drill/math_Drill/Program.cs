using System;

namespace math_Drill
{
    class Program
    {
        static void Main()
        {
            //1.input from the user - multiplied by 50 

            Console.WriteLine("1. Please enter a number to see multiplication magic?");
            int product = Int32.Parse(Console.ReadLine()) * 50;
            Console.WriteLine("Your number multiplied by 50 is " + product);


            //2. added 25 to the user's input

            Console.WriteLine("2. Please enter a number to see addition magic?");
            int total = Int32.Parse(Console.ReadLine()) + 25;
            Console.WriteLine("Ops, I added 25 to your number and you got " + total);

            //3.user's input divided by 12.5

            Console.WriteLine("3. What about a division magic?");
            double quotient = double.Parse(Console.ReadLine()) / 12.5;
            Console.WriteLine("Your number divided by 12.5, you got " + quotient);

            //4. user's input checked if it is greater than 50

            Console.WriteLine("4.Lets check if the number you enter is greater than 50?");
            bool checker = double.Parse(Console.ReadLine()) > 50;
            Console.WriteLine(checker.ToString());

            //5.user's inpput divided by 7 and remainder is printed out 

            Console.WriteLine("5. Let find out the reminder when your number is divided by 7?");
            double remainder = double.Parse(Console.ReadLine()) % 7;
            Console.WriteLine("The remainder is " + remainder);
            Console.Read();
        }
    }
}
