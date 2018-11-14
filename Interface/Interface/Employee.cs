using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            //Console.WriteLine("Name: " + "[ " + FirstName + "  " + LastName + " ]");
        }
        
        public void Quit()
        {
            Console.WriteLine("\n\n\n\n\n\n " +
                "\t\t\t\t  This is a C# \"Interface\" & \"Polymorphism\" in action!!");
        }
    }
}
