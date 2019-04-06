using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_124
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { FirstName = "Sample", LastName = "Student", ID = 001 };
            employee1.SayName();
            employee1.Quit();

            IQuittable quit = new Employee() { FirstName = "Sam", LastName = "Stud" };           
            quit.Quit();

            Employee employee2 = new Employee() { FirstName = "Zach", LastName = "Murray", ID = 002 };



            //string ID = employee.FirstName + employee.LastName;
            //Console.WriteLine(ID);

            Console.Write("Employee's ID is same: ");
            Console.WriteLine(employee1 == employee2);


            Console.WriteLine();
            Console.ReadLine();
        }


        
    }
}
