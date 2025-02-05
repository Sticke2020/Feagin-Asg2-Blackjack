using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feagin_Asg2_Blackjack
{
    internal class Deck
    {
        // Make a list for the cards
        private List<Card> listCards = new List<Card>();


        public Deck()
        {
            loadDeck();
        }

        private void loadDeck()
        {
            // Clear the list
            listCards.Clear();

            // Create Card object
            Card card;

            // Add cards to list in specific order

            int imageIndex = 0;

            for (int i = 1; i <= 13; i++)
            {
                card = new Card(i, Card.CardSuit.Clubs, imageIndex);
                listCards.Add(card);
                imageIndex++;

                card = new Card(i, Card.CardSuit.Diamonds, imageIndex);
                listCards.Add(card);
                imageIndex++;

                card = new Card(i, Card.CardSuit.Hearts, imageIndex);
                listCards.Add(card);
                imageIndex++;

                card = new Card(i, Card.CardSuit.Spades, imageIndex);
                listCards.Add(card);
                imageIndex++;
            }
        }
    }
}
