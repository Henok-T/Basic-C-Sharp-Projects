using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreOnExceptions
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter your age to find out your birth \"Year\"!");
            try
            {
                bool userAge = false;
                int age = 1;
                while (!userAge)
                {
                    userAge = int.TryParse(Console.ReadLine(), out age);
                    if (!userAge)
                    {
                        Console.WriteLine("\n Error. Only whole postive numbers are accepted.");
                    } 
                }
                if(age <= 0)
                {
                    throw new AgeEntryInvalidException();
                }

                DateTime thisYear = DateTime.Now;
                int ThisYear =Convert.ToInt32(thisYear.Year);
                int YearBorn = ThisYear - age;
                Console.WriteLine("\n Year Of Birth: {0}" , YearBorn);
            }
            catch (AgeEntryInvalidException)
            {
                Console.WriteLine("\n Errorrr. Only Whole postive numbers are accepted.");
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("\n Irreconcilable Errorrr. Please try again later." );
                return;
            }
            finally
            {
                Console.WriteLine("\n Press enter/return key to exit the program.");
                
            }

            Console.ReadLine();
        }
    }
}
