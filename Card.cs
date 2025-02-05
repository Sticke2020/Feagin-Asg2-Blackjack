using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Feagin_Asg2_Blackjack
{
    internal class Card
    {
        // What are some properties of a card
        // Suit  Clubs, Diamonds, Hearts, Spades
        // Rank A, 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K

        public enum CardSuit { Clubs, Diamonds, Hearts, Spades }

        public CardSuit Suit { get; set; }

        public int Rank { get; set; }

        public int ImageIndex { get; set; }

        
        public Card()
        {
            
        }

        public Card(int rank, CardSuit suit, int imageIndex)
        {
            Rank = rank;
            Suit = suit;
            ImageIndex = imageIndex; 
        }

        public override string ToString()
        {
            String rank = "";

            if(Rank == 1)
            {
                rank = "Ace";
            }
            else if(Rank == 11)
            {
                rank = "Jack";
            }
            else if(Rank == 12)
            {
                rank = "Queen";
            }
            else if(Rank == 13)
            {
                rank = "King";
            }
            else
            {
                rank = Rank.ToString();
            }

            return rank + " " + Suit.ToString() + " Index: " + ImageIndex.ToString();
        }


    }
}
