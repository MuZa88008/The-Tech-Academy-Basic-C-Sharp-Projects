using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDrill
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number to perform some math functions on: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int staticInt = 10;

            Math math = new Math();

            int result1 = math.Add(userInput,staticInt);
            int result2 = math.Subtract(userInput, staticInt);
            int result3 = math.Multiply(userInput, staticInt);

            Console.WriteLine(userInput + " + " + staticInt + " = " + result1);
            Console.WriteLine(userInput + " - " + staticInt + " = " + result2);
            Console.WriteLine(userInput + " * " + staticInt + " = " + result3);

            Console.ReadKey();
        }

      
    }
}
