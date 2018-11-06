using System;
using System.Text;

namespace String_Drill
{
    class Program
    {
        static void Main()
        {
            string title = "Coffee Ipsum\n";
            string sentence1 = "Percolator coffee whipped variety robust eu\n";
            string sentence2 = "froth sweet, variety spoon a redeye.";
            Console.WriteLine(title.ToUpper() + sentence1 + sentence2);
            Console.Read(); // just to make a space between

            StringBuilder sb = new StringBuilder("Lorem Ipsum\n");

            sb.Append("This is sentence 1. Lorem ipsum dolor sit amet, consectetur adipiscing elit.\n");
            sb.Append("This is sentence 2. Sed ante lectus, volutpat in justo non, vulputate imperdiet lectus.\n");
            sb.Append("This is sentence 3. Mauris a magna augue. Quisque posuere ultricies pharetra.");
            Console.WriteLine(sb);
            System.Threading.Thread.Sleep(10000);
            Console.Read();

        }
    }
}
