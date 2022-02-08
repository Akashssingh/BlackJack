using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G19BlackJack
{
    public partial class aShoe : aRandomVariable, IDrawCard
    {
        public aCard[] allDecks;
        public int size = 0;
        public aShoe(int seed, int numDecks)
        {
            allDecks = new aCard[52*numDecks];
            rand = new Random(seed);
            aDeckOfCards aDeck = new aDeckOfCards();

            for (int i = 0; i < numDecks; i++)
            {
                for (int j = 0; j < aDeck.deck.Length; j++)
                {
                    allDecks[(52*i) + j] = aDeck.deck[j];
                }
            }

            aShoe.shuffle(allDecks);
            size = allDecks.Length - 1;
        }


        public aCard Draw()
        {
            aCard card = allDecks[size];
            size--;
            return card;
        }

        public static aCard[] shuffle(aCard[] allDecks)
        {
            for (int i = allDecks.Length - 1; i > 0; i--)
            {
                int r = rand.Next(0, i);
                aCard temp = allDecks[i];
                allDecks[i] = allDecks[r];
                allDecks[r] = temp;
            }

            return allDecks;
        }
    }
}
