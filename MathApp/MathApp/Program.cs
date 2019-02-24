using System;

namespace MathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Takes an input from the user, multiplies it by 50, and prints the result to the console. (Note: make sure your code can take inputs larger than 10,000,000)

            Console.WriteLine("Enter a whole number...:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int output1 = num1 * 50;
            Console.WriteLine(num1 + " multiplied by 50 is... " + output1);
            Console.WriteLine("press ENTER to continue...");
            Console.ReadLine();


            //// 2. Takes an input from the user, adds 25 to it, and prints the result to the console.

            Console.WriteLine("Enter a whole number...:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int output2 = num2 + 25;
            Console.WriteLine(num2 + " plus 25 is... " + output2);
            Console.WriteLine("press ENTER to continue...");
            Console.ReadLine();

            //// 3. Takes an input from the user, divides it by 12.5, and prints the result to the console.

            Console.WriteLine("Enter a whole number...:");
            int num3 = Convert.ToInt32(Console.ReadLine());
            double output3 = (double)num3 / 12.5;
            Console.WriteLine(num3 + " divided by 12.5 is... " + output3);
            Console.WriteLine("press ENTER to continue...");
            Console.ReadLine();


            // 4.Takes an input from the user, checks if it is greater than 50, and prints the true / false result to the console.

            Console.WriteLine("Enter a whole number...:");
            int num4 = Convert.ToInt32(Console.ReadLine());
            bool output4 = num4 > 50;
            Console.WriteLine("'" + num4 + " is greater than 50' is " + output4);
            Console.WriteLine("press ENTER to continue...");
            Console.ReadLine();

            // 5. Takes an input from the user, divides it by 7, and prints the remainder to the console (tip: think % operator).

            Console.WriteLine("Enter a whole number...:");
            int num5 = Convert.ToInt32(Console.ReadLine());
            int output5 = num5 % 7;
            Console.WriteLine("The remainder of "+ num5 + " divided by 7 is " + output5);
            Console.WriteLine("press ENTER to continue...");
            Console.ReadLine();
            
        }
    }
}
