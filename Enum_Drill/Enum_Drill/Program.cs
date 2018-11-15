using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Drill
{
    class Program
    {
        enum WeekDays
        { Monday = 0, Tuesday = 1, Wednesday = 2, Thursday = 3, Friday = 4, Saturday = 5, Sunday = 6 }
        
        static void Main()
        {
            try
            {
                Console.WriteLine("What Day is Today?");
                string todayIs = Console.ReadLine();
                WeekDays wkDay = (WeekDays)Enum.Parse(typeof(WeekDays), todayIs);
                Console.WriteLine("\n\t Today has an enum data type of  " + (int)wkDay + ".");
            }
            catch (Exception)
            {
                Console.WriteLine("Please try again by entering an actual day of the week or check your spelling.");
            }
            Console.ReadLine();
        }
        
    }
}
