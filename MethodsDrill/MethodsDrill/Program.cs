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
            Console.WriteLine("Please enter a number to perform some math functions on: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int staticInt = 10;

            int result1 = Add(userInput,staticInt);
            int result2 = Subtract(userInput, staticInt);
            int result3 = Multiply(userInput, staticInt);

            Console.WriteLine(userInput + " + " + staticInt + " = " + result1);
            Console.WriteLine(userInput + " - " + staticInt + " = " + result2);
            Console.WriteLine(userInput + " * " + staticInt + " = " + result3);

            Math math = new Math();


            Console.ReadKey();
        }

      
    }
}
