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
            Console.ReadLine();

            Console.WriteLine(math.math(10));
            Console.ReadLine();
        }
    }
}
