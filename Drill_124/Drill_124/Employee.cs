using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_124
{
    class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            base.SayName();
        }
        public void Quit()
        {
            Console.WriteLine(FirstName + " " + LastName + " has quit!!");
        }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            if ((employee1.ID == employee2.ID) && (employee1.ID == employee2.ID))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Employee employee1, Employee employee2)
        {
            if ((employee1.ID != employee2.ID) || (employee1.ID != employee2.ID))
            {
                return true;
            }
            return false;
        }
    }

}
