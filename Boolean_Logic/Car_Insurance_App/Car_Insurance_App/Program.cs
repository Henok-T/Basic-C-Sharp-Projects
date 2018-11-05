using System;

namespace Car_Insurance_App
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Tech Academy Auto Insurance");

            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Have you ever had DUIs? Please answer \"True\" or \"False\".");
            bool dui = bool.Parse(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            int ticket = int.Parse(Console.ReadLine());
            
            bool qualified = (age > 15) && (!dui) && (ticket <= 3);
            Console.WriteLine("Qualified: " + qualified);

            
            Console.Read();
        }
    }
}
