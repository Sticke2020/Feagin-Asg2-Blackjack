using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feagin_Asg2_Blackjack
{
    internal class Card
    {
        // What are some properties of a card
        // Suit  Clubs, Diamonds, Hearts, Spades
        // Rank A, 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K

        public enum CardSuit { Clubs, Diamonds, Hearts, Spade }

        public CardSuit Suit { get; set; }

        public int Rank { get; set; }

        public int ImageIndex { get; set; }

        
        public Card()
        {
            
        }

        public Card(int rank, CardSuit suit, int imageIndex)
        {
            Rank = rank;
            ImageIndex = imageIndex; 
        }



    }
}
