using System;

namespace Loops_Drill
{
    class Program
    {
        static void Main()
        {
            string do_it_Again = "";
            do
            {
                Console.WriteLine("Give me a number above 200 and you will get a beautiful pattern of even numbers.");
                int chosenNumber = int.Parse(Console.ReadLine());
                int i = 0;

                while (i <= chosenNumber)
                {
                    Console.Write(i + ">>>>>>>>>>>>>>>>>>######################>>>>>>>>>>>>>>>>>>");
                    i += 2;
                }
                do
                {
                    Console.WriteLine("Do you want to do it again? Please write Yes or No? ");
                    do_it_Again = Console.ReadLine();
                    if (do_it_Again != "Yes" && do_it_Again != "No")
                    {
                        Console.WriteLine("Invalid choice. Please check the spelling.");
                    }
                } while (do_it_Again != "Yes" && do_it_Again != "No");
            } while (do_it_Again == "Yes");
        }
    }
}
