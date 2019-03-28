using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne3
{
    class Program
    {
        static void Main(string[] args)
        {
            CardClass cardOne = new CardClass();  //instantiate object - still empty however.
            //cardOne.Face = "Queen";
            //cardOne.Suit = "Hearts";

            Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);
            Console.ReadLine();
        }
    }
}
