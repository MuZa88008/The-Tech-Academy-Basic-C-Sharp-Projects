using System;

namespace Branching_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            //The first line of the program must be: “Welcome to Package Express. Please follow the instructions below.”
            Console.WriteLine("Welcome to Package Express.  Please follow the instructions below.");

            //The user must then be prompted for the package weight.
            Console.WriteLine("What is the package weight");
            decimal weight = Convert.ToDecimal(Console.ReadLine());

            //If the weight is greater than 50, display the error message, “Package too heavy to be shipped via Package Express.Have a good day.” At this point the program would end.
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.");
                Console.WriteLine("Have a good day.");
                Console.ReadLine();
            }

            //The user must then be prompted for the package width.
            else
            {
                Console.WriteLine("What is the package width");
                decimal width = Convert.ToDecimal(Console.ReadLine());

                //Then the package height.
                Console.WriteLine("What is the package height");
                decimal height = Convert.ToDecimal(Console.ReadLine());

                //Then the package length.
                Console.WriteLine("What is the package length");
                decimal length = Convert.ToDecimal(Console.ReadLine());

                decimal dimensions = width + height + length;

                //If the sum of the dimensions is greater than 50, display the error message, “Package too big to be shipped via Package Express.” At this point the program would end.
                if (dimensions > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }

                //The sum total of dimensions are then multiplied by the weight and divided by 100.
                //The result of that calculation is the quote.
                else
                {
                    decimal quote = (dimensions * weight / 100);
                    //Display the quote to the user as a dollar amount.
                    Console.WriteLine("You shipment quote is: $" + quote);
                    Console.WriteLine("Thank You!");
                    Console.ReadLine();
                }
            }
        }
    }
}
