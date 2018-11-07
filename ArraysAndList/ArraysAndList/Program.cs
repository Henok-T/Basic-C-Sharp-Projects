using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysAndList
{
    class Program
    {
        static void Main()
        {

            // Array of Strings - The Secret Word
            string[] strArray = { "you are amazing.", "you are awsome.", "you are a masterpiece." };

            Console.WriteLine("Please select a number from 0-2 for a secret word.");
            int selectedWord = int.Parse(Console.ReadLine());
        
            for (int i = 0; i < strArray.Length; i++)
            {
                if (selectedWord == 0)
                {
                    Console.WriteLine("Remember that, " + strArray[0] + "\n");
                    break;
                }
                else if (selectedWord == 1)
                {
                    Console.WriteLine("Remember that, " + strArray[1] + "\n");
                    break;
                }
                else if (selectedWord == 2)
                {
                    Console.WriteLine("Remember that, " + strArray[2] + "\n");
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, you entered a wrong number. Please try again later.");
                    System.Threading.Thread.Sleep(5000);
                    Environment.Exit(0); while (selectedWord != 0 && selectedWord != 1 && selectedWord != 2) ;
                }

            }
            
            //Array of integers - The Big Number
            int[] myArraynums = { 100, 200, 300, 400, 500 };

            Console.WriteLine("Please select a number from 0-4 for a Big Number.");
            int selectedNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < myArraynums.Length; i++)
            {
                if (selectedNum == 0)
                {
                    Console.WriteLine("Your Big Number is: " + myArraynums[0] + "\n");
                    break;
                }
                else if (selectedNum == 1)
                {
                    Console.WriteLine("Your Big Number is: " + myArraynums[1] + "\n");
                    break;
                }
                else if (selectedNum == 2)
                {
                    Console.WriteLine("Your Big Number is: " + myArraynums[2] + "\n");
                    break;
                }
                else if (selectedNum == 3)
                {
                    Console.WriteLine("Your Big Number is: " + myArraynums[3] + "\n");
                    break;
                }
                else if (selectedNum == 4)
                {
                    Console.WriteLine("Your Big Number is: " + myArraynums[4] + "\n");
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, you entered a wrong number. Please try again later.");
                    System.Threading.Thread.Sleep(5000);
                    Environment.Exit(0);
                }
            }

            // List of Strings - The Car-Model
            List<string> euCars = new List<string>();
            euCars.Add("BMW");
            euCars.Add("Volvo");
            euCars.Add("Citron");
            euCars.Add("VW");

            Console.WriteLine("Please select a number from 0-3 for a car-Model.");
            int selectedCar = int.Parse(Console.ReadLine());

            for (var i = 0; i < euCars.Count; i++)
            {
                if (selectedCar == 0)
                {
                    Console.WriteLine("I bet, you would look awsome if you drive " + euCars[i] + "." + "\n");
                }
                else if (selectedCar == 1)
                {
                    Console.WriteLine("I bet, you would look awsome if you drive " + euCars[i] + "." + "\n");
                    break;
                }
                else if (selectedCar == 2)
                {
                    Console.WriteLine("I bet, you would look awsome if you drive " + euCars[i] + "." + "\n");
                    break;
                }
                else if (selectedCar == 3)
                {
                    Console.WriteLine("I bet, you would look awsome if you drive " + euCars[i] + "." + "\n");
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, you entered a wrong number. Please try again later.");
                    System.Threading.Thread.Sleep(5000);
                    Environment.Exit(0);
                }
            }
            Console.Read();
        }
    }
}
