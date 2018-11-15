using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpress
{
    public class Program
    {
        public static void Main()
        {
            List<Employee> emply = new List<Employee>();
            emply.Add(new Employee { FirstName = "Joe", LastName = "John", Id = 1 });
            emply.Add(new Employee { FirstName = "Joe", LastName = "Smith", Id = 2 });
            emply.Add(new Employee { FirstName = "Joe", LastName = "Zimmerman", Id = 3 });
            emply.Add(new Employee { FirstName = "Nancy", LastName = "Davolio", Id = 4 });
            emply.Add(new Employee { FirstName = "Andrew", LastName = "Fuller", Id = 5 });
            emply.Add(new Employee { FirstName = "Robert", LastName = "King", Id = 6 });
            emply.Add(new Employee { FirstName = "Adam", LastName = "West", Id = 7 });
            emply.Add(new Employee { FirstName = "Maragret", LastName = "Peacock", Id = 8 });
            emply.Add(new Employee { FirstName = "Steven", LastName = "Buchanan", Id = 9 });
            emply.Add(new Employee { FirstName = "Kari", LastName = "Nordmann", Id = 10 });

            List<Employee> newList = new List<Employee>();
            foreach (var person in emply )
                {
                    if(person.FirstName == "Joe")
                    {
                        newList.Add(person);
                        Console.WriteLine(person.FirstName + " " + person.LastName + "\n");
                    }
                }

            Console.WriteLine("\n==============//============\n");

            //Lambda expression 
            List<Employee> joeList = emply.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employee person in joeList)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName + "\n");
            }

            Console.WriteLine("\n==============//============\n");

            //Lambda expression 
            List<Employee> idOver5 = emply.Where(x => x.Id > 5).ToList();
            foreach(Employee person in idOver5)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName + "\n");
            }

            Console.ReadLine();
        }
    }
}
