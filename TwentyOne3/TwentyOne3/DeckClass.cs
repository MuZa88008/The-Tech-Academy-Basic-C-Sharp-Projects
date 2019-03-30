using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne3
{
    public class DeckClass
    {
        public DeckClass() // contstructor always before properties... named same as class (eg. DeckClass())
        {
            // Below creates one card ( Two of Spades)...This section is not used in favor of loops to create all the cards...//Cards = new List<CardClass>();
            //CardClass cardOne = new CardClass();
            //cardOne.Face = "Two";
            //cardOne.Suit = "Spades";
            //Cards.Add(cardOne);

            Cards = new List<CardClass>(); // create/instantiate the Cards list - property is set below but no object instantiated till this line.
            List<string> Suits = new List<string>()
            {
                "Clubs", "Hearts", "Diamonds", "Spades"
            };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven", "Eight",
                "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            foreach (string suit in Suits)
            {
                foreach (string face in Faces)
                {
                    CardClass card = new CardClass();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }


        }
        public List<CardClass> Cards { get; set; }
    }
}
