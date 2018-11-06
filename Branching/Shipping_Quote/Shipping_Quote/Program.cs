using System;

namespace Shipping_Quote
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            int packageWeight = int.Parse(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.WriteLine("Package to heavy to be shipped via Package Express. Have a good day.");
                System.Threading.Thread.Sleep(5000);
                Environment.Exit(0);
            }

            Console.WriteLine("Please enter the package width:");
            int packageWidth = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            int packageHeight = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            int packageLength = int.Parse(Console.ReadLine());

            // calcutating package dimension
            int packageDimension = packageLength + (2 * packageWidth) + (2 * packageHeight);

            if (packageDimension > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                System.Threading.Thread.Sleep(5000);
                Environment.Exit(0);
            }
            else
            {
                // Pricing
                float quotePrice = packageDimension * packageWeight / 100;
                Console.WriteLine("Your estimated total for shipping this package is: " + "$" + quotePrice);
                Console.Read();
            }
        }
    }
}
