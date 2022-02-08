using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G19BlackJack
{
    public class aCard
    {
        //stores the suit of cards 
        public enum Suits
        {
            Hearts, Diamonds, Clubs, Spades
        }

        public int Face
        {
            get;
            set;
        }

        public Suits Suit
        {
            get;
            set;
        }


        //creates a card
        public aCard(Suits s, int f)
        {
            Suit = s; //suit of card
            Face = f; //value of card
        }
    }
}
