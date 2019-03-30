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
            DeckClass deck = new DeckClass(); // instantiated deck object - still empty however - CardOne is added at index [0] to Cards list in the DeckClass constructor.

            foreach (CardClass card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
            //Below not used in favor of DeckClass.cs constructor
            //deck.Cards = new List<CardClass>(); // instantiated data type list<CardClass> - we can add cards to this property of the deck, Cards

            //CardClass cardOne = new CardClass();  //instantiate object - still empty however.
            //cardOne.Face = "Queen";
            //cardOne.Suit = "Hearts";

            //deck.Cards.Add(cardOne);


            //Console.WriteLine(deck.Cards[0].Face + " of " + deck.Cards[0].Suit);
            //Console.ReadLine();
        }
    }
}
