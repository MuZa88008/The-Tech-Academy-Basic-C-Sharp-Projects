using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game
    {
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public abstract void Play();
        /*abstract method - can only exist inside abstract class, contains no implementation, 
        any class inheriting this class must implement this method.*/

        public virtual void ListPlayers ()
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
