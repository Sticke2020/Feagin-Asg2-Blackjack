using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feagin_Asg2_Blackjack
{
    public class Hand
    {
        private List<Card> listOfCards = new List<Card>();

        public Hand()
        {
        }

        public void addCard(Card card)
        {
            listOfCards.Add(card);
        }

        public void clearHand()
        {
            listOfCards.Clear();
        }

        public int count()
        { 
            return listOfCards.Count();
        }

        public int getBlackJackTotal()
        {
            int total = 0;
            int aceCount = 0;

            foreach (Card card in listOfCards)
            {
                if (card.blackJackValue() == 1)
                {
                    aceCount += 1;
                }
                total = total + card.blackJackValue();
            }

            if(aceCount > 0)
            {
                if (total >= 7 && total <= 11)
                {
                    total = total + 10;
                }
            }
            return total;
        }

    }
}
