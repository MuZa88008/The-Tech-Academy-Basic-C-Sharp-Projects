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
            Divide divide = new Divide();

            //-----------Comment Break Here for Int ---------------------------------
            //Console.WriteLine("Enter a Number: ");
            //int input = Convert.ToInt32(Console.ReadLine());
            //int output;

            //divide.Math(input, out output);

            //Console.WriteLine(output);
            //Console.ReadLine();


            // -------------------Comment Break Here for Decimal-------------------------
            Console.WriteLine("Enter a Decimal: ");
            decimal input = Convert.ToDecimal(Console.ReadLine());
            decimal example2;

            divide.Math(input, out example2);

            Console.WriteLine(example2);
            Console.ReadLine();

        }
    }
}
