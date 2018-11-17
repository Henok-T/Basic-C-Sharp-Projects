using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeatures
{
    class Program
    {
        static void Main()
        {
            const int remainingDays = 44;
            Console.WriteLine("\n I'm left with {0} remaining days of access to the LMS.", remainingDays );

            var comingHoliday = new DateTime(2018,11,22);
            Console.WriteLine("\n Thanksgiving is next week on {0}", comingHoliday + "\n\n\t\t HAPPY" + "\n\t THANKSGIVING");

            

            Console.ReadLine();
        }
    }
}
