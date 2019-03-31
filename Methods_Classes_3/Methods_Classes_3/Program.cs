using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Classes_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            Console.WriteLine(math.math(12));

            Console.WriteLine(math.math(10.33m));

            Console.WriteLine(math.math("200"));

            Console.ReadLine();
        }
    }
}
