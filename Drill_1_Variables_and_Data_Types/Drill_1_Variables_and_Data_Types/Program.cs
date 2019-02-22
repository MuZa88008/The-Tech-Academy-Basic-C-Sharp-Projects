using System;

namespace Drill_1_Variables_and_Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.Write(Environment.NewLine);
            Console.WriteLine("Student Daily Report");
            Console.Write(Environment.NewLine);
            Console.Write(Environment.NewLine);
            Console.WriteLine("What course are you on?");
            string crsvar = Console.ReadLine();
            Console.WriteLine("What page?");
            string pagevar = Console.ReadLine();
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\" ");
            string help = Console.ReadLine();
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string wins = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            Console.WriteLine("Thank you for your answers.  An Instructor will respond to this shortly.  Have a fantastic Day!");
            Console.ReadLine();

        }
    }
}
