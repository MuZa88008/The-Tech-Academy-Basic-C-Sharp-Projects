using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_124
{
    public abstract class Person
    {
        public virtual void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }


    }
}
