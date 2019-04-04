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
            Employee employee1 = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee1.SayName();
            employee1.Quit();

            IQuittable quit = new Employee() { FirstName = "Sam", LastName = "Stud" };           
            quit.Quit();

            Employee employee2 = new Employee() { FirstName = "Zach", LastName = "Murray" };

            //string ID = employee.FirstName + employee.LastName;
            //Console.WriteLine(ID);

            Console.WriteLine(employee1 == employee2);


            Console.WriteLine();
            Console.ReadLine();
        }


        public static bool operator == (Employee employee1, Employee employee2)
        {
            if ((employee1.FirstName == employee2.FirstName) && (employee1.LastName == employee2.LastName))
            {
                return true;
            }
            return false;
        }

        public static bool operator != (Employee employee1, Employee employee2)
        {
            if ((employee1.FirstName != employee2.FirstName) || (employee1.LastName != employee2.LastName))
            {
                return true;
            }
            return false;
        }
    }
}
