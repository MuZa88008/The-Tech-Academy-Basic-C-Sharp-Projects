using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace While_Loop_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to count down from...:");
            Console.WriteLine("**Program will countdown from number entered to zero (250ms) and beep at each count (+50hz each interval)...");
            int count = Convert.ToInt32(Console.ReadLine());
            int hertz = 500;

            while (count > 0)
            {
                count--;
                Thread.Sleep(250);
                Console.Beep(hertz, 50);
                Console.WriteLine(count);
                hertz = hertz + 50;
            }
            Console.WriteLine("End... Press ENTER to exit");
            Console.ReadLine();
        }
    }
}

