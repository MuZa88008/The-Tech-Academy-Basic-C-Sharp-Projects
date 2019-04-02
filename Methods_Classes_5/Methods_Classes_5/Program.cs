using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Classes_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Divide divide = new Divide();
            divide.Math(input);
            Console.ReadLine();

        }
    }
}
