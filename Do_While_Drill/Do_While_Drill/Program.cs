using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("How many sides on a Nonagon?: ");
            Console.WriteLine("** The answer is 9, but make a guess or several above and below 9 to see program logic...**");
            int guess = Convert.ToInt32(Console.ReadLine());
            bool test_expression = false;

            do
            {
                if (guess == 9)
                {
                    Console.WriteLine("That is correct!");
                    Console.ReadLine();
                    test_expression = true;
                }
                else if (guess > 9)
                {
                    Console.WriteLine("Nice try... but guess lower...");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                else if (guess < 9)
                {
                    Console.WriteLine("Good guess... try higher...");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
            }
            while (test_expression == false);
        }
    }
}
