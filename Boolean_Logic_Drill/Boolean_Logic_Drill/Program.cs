using System;

namespace Boolean_Logic_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Have you ever had a DUI? Enter \"true\" or \"false\" ");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine();


            Console.WriteLine("How many speeding tickets do you have?: ");
            int tickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();





            Console.WriteLine("Age: " +age);
            Console.WriteLine("Has Dui: " + dui);
            Console.WriteLine("Tickets: " + tickets);
            Console.WriteLine();
            Console.WriteLine();


            bool qualinsurance = (age > 15 && dui != true && tickets <= 3);
            Console.WriteLine("Qualified: " + qualinsurance);

            //Console.WriteLine("Qualified for Insurance?");
            //Console.WriteLine(qual);

            //Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\" ");
            //bool help = Convert.ToBoolean(Console.ReadLine());

            //Console.WriteLine(age);
            Console.ReadLine();

        }
    }
}
