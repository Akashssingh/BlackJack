using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G19BlackJack
{
    public class aDeckOfCards
    {
        //deck array of cards 
        public aCard[] deck = new aCard[52];

        //initialize the deck of cards
        public aDeckOfCards()
        {
            this.makeDeck();
        }

        //make the deck of cards with i being the suit and j+1 being the face value 
        public void makeDeck() {

            //for each suit
            for(int i = 0; i < 4; i++){
                //set face value where 1 is Ace, 11 is Jack, 12 is Queen, and 13 is King 
                for (int j = 0; j < 13; j++)
                {
                    deck[(i * 13) + j] = new aCard((aCard.Suits)i, j+1);
                }
            }
        }

    }
}
