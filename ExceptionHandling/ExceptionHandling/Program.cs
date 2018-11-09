using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            
            

            try
            {
                List<int> myNums = new List<int> { 100, 200, 300, 400, 500 };
                Console.WriteLine("Please enter a number:");
                int userNum = int.Parse(Console.ReadLine());
                foreach (int item in myNums)
                {
                    int result = item / userNum;
                    Console.WriteLine(result);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message + "\n" + "----- Please enter a whole number.-----");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message + "\n" + "----- Sorry! Can not divide by zero. ------");
            }
            finally
            {
                Console.WriteLine("\n \n Press Enter/return to exit the program.");
                Console.ReadLine();
            }



            Console.ReadLine();
        }
    }
}
