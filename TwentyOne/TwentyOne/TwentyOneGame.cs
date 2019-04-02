using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneGame : Game
    {
        // program will not compile without Play() used.
        public override void Play() // override used to use the abstract method Play() in Game.
        {
            throw new NotImplementedException();
        }
        public override void ListPlayers()
        {
            Console.WriteLine("Welcome 21 Players: ");
            base.ListPlayers();
        }
    }
}
