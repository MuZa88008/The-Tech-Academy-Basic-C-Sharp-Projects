using System;

namespace Math_And_Comparision_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1:");
            Console.WriteLine("Hourly Rate?");
            int hourlyrate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int hrsperwk1 = Convert.ToInt32(Console.ReadLine());
            int annualsalary1 = hourlyrate1 * hrsperwk1 * 52;

            Console.WriteLine("Person 2:");
            Console.WriteLine("Hourly Rate?");
            int hourlyrate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int hrsperwk2 = Convert.ToInt32(Console.ReadLine());
            int annualsalary2 = hourlyrate2 * hrsperwk2 * 52;
            // no assumptions made for paid/unpaid vacation etc... annual salary = weekly * 52 weeks.

            bool morethan = annualsalary1 > annualsalary2;

            Console.WriteLine("Annual salary of Person 1...:");
            Console.WriteLine(annualsalary1);

            Console.WriteLine("Annual salary of Person 2...:");
            Console.WriteLine(annualsalary2);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(morethan);

            Console.ReadLine();

        }
    }
}

 