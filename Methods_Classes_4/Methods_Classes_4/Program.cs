using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Classes_4
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.WriteLine("Enter a whole number:    ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You many enter another whole number if you want: ");
            string entry = Console.ReadLine();

            if (string.IsNullOrEmpty(entry))
            {
                Console.WriteLine(num2 = 0);
            }
            else
            {
                num2 = Convert.ToInt32(entry);
            }

            MathOperation mathOperation = new MathOperation();

            Console.WriteLine(mathOperation.math(num1, num2));
            Console.ReadLine();

        }
    }
}
