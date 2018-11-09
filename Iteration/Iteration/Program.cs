using System;
using System.Collections.Generic;
using System.Text;

namespace Iteration
{
    class Program
    {
        static void Main()
        {
            //#1 
            Console.WriteLine("\n========== Q1 =========\n");
            string[] bookList = { "Book1", "Book2", "Book3", "Book4", "Book5" };
            Console.WriteLine("Please enter any text.");
            string newTitle = Console.ReadLine();

            for (int j = 0; j < bookList.Length; j++)
            {
                bookList[j] += " " + newTitle;
            }

            foreach (string book in bookList)
            {
                Console.WriteLine(book);
            }

            //#2 & #3  Example of an uninfinte loop
            Console.WriteLine("\n======= Q2 & Q3 ========\n");
            Console.WriteLine("Please refere to the code to see the infinte loop example.\n");
            int i = 0;
            while (i <= 15)
            {
                Console.Write(i + "\n");
                i += 5; // if you comment out this line of code , 
                        //the result'll be an infine loooooop.
            }

            //4. Loop with a "<" operator
            Console.WriteLine("\n========== Q4 =========\n");
            for (int k = 0; k < 5; k++)
            {
                Console.Write(k + " Example loop with < operator\n");
            }

            //5. Loop with a ">" operator
            Console.WriteLine("\n========== Q5 =========\n");
            for (int h = 10; h > 5; h--)
            {
                Console.Write(h + " Example loop with > operator\n");
            }

            ////#6 , #7 & #8
            Console.WriteLine("\n======= Q6 , Q7 & Q8 ========\n");
            List<string> listColors = new List<string>()
            { "red","blue","green","yellow","black","purple","white","pink"};

            Console.WriteLine("Please enter your favorite color name?");
            string textEntry = (Console.ReadLine()).ToLower();

            var c = 0;
            bool colorFound = false;
            while (c < listColors.Count)
            {
                if (textEntry == listColors[c])
                {
                    colorFound = true;
                    Console.WriteLine("Your fav color index no.  " + c);
                }
                c++;
            }
            if (colorFound == false)
            {
                Console.WriteLine("Sorry ,you entered a wrong text.");
            }

            // #9 & Q10
            Console.WriteLine("\n========== Q9 & Q10 =========\n");
            List<string> statesList1 = new List<string>()
            { "ME", "MD", "MI", "MA", "MI", "MN", "MS", "MO", "MI", "MT" };
            Console.WriteLine("Please enter State postal code that starts with the letter \"M\" ?");
            string searchKey = (Console.ReadLine()).ToUpper();

            var s = 0;
            bool stateFound = false;
            while (s < statesList1.Count)
            {
                if (searchKey == statesList1[s])
                {
                    stateFound = true;
                    Console.WriteLine("You enterd State " + statesList1[s] + " & its index no. is " + s);
                }
                s++;
            }
            if (stateFound == false)
            {
                Console.WriteLine("Sorry ,you entered a wrong text.");
            }

            // #11
            Console.WriteLine("\n========== Q11 =========\n");
            List<string> duplicated = new List<string>();

            foreach (string item in statesList1)
            {
                if (!duplicated.Contains(item))
                {
                    duplicated.Add(item);
                    Console.WriteLine("The State " + item + " appears for the first time.");
                }
                else
                {
                    Console.WriteLine("The State " + item + " has ALREADY APPEARED in the list.");
                }
            }


            Console.WriteLine("\n-----------" + ">"+"   *   "+"<"+"----------");
            Console.WriteLine("------------" +  ">" + "   T   " + "<" + "---------");
            Console.WriteLine("--------------" +  ">" + "   H   " + "<" + "---------");
            Console.WriteLine("---------------" +">" + "   E   " + "<" + "----------");
            Console.WriteLine("----------------" +  ">" + "   *   " + "<" + "-----------");
            Console.WriteLine("-----------------" + ">" + "   *   " + "<" + "------------");
            Console.WriteLine("----------------" +  ">" + "   *   " + "<" + "------------");
            Console.WriteLine("---------------" +  ">" + "   E   " + "<" + "----------");
            Console.WriteLine("---------------" +  ">" + "  N   " + "<" + "---------");
            Console.WriteLine("--------------" +  ">" + "  D  " + "<" + "--------");
            Console.WriteLine("-------------" +  ">" + "   *   " + "<" + "-------");
            Console.WriteLine("------------" +  ">" + "   *   " + "<" + "------");



            Console.Read();
            


        }
    }
}
