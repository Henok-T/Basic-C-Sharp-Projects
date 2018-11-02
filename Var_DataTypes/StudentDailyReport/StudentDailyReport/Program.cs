using System;

namespace Stud_DailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Adacemy");
            Console.WriteLine("Student Daily Report");
            //Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string currentCourse = Console.ReadLine();
            //Console.ReadLine();

            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            //Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer " +
                               "\"true\" or \"false\".");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());
            // Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you’d like to share? " +
                              "Please give specifics.");
            string postiveExpce = Console.ReadLine();
            //Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? " +
                             "Please be specific.");
            string feedBack = Console.ReadLine();
            //Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            int studyHrs = Convert.ToInt32(Console.ReadLine());
            //Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An Instructor will " +
                            "respond to this shortly. Have a great day!");
            Console.ReadLine();



        }
    }
}

