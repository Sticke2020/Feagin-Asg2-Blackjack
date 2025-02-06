using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Feagin_Asg2_Blackjack
{
    public partial class FormMain : Form
    {
        // Deck is global so all methods in FormMain can access the same deck
        Deck deck;

        int hitCount = 1;
        int playerWins = 0;
        int playerTotal = 0;
        int dealerWins = 0;
        int dealerTotal = 0;
        int gamesPlayed = 0;

        public FormMain()
        {
            InitializeComponent();
        }

        private void hidePictureBoxes()
        {
            
            pictureBoxDealer2.Visible = false;
            pictureBoxDealer3.Visible = false;
            pictureBoxDealer4.Visible = false;
            pictureBoxDealer5.Visible = false;
            pictureBoxDealer6.Visible = false;
            pictureBoxDealer7.Visible = false;
            pictureBoxDealer8.Visible = false;

            pictureBoxPlayer1.Visible = false;
            pictureBoxPlayer2.Visible = false;
            pictureBoxPlayer3.Visible = false;
            pictureBoxPlayer4.Visible = false;
            pictureBoxPlayer5.Visible = false;
            pictureBoxPlayer6.Visible = false;
            pictureBoxPlayer7.Visible = false;
            pictureBoxPlayer8.Visible = false;
        }

       private void checkForBust(int total)
        {
            if (total == 21)
            {
                labelBust.Text = "BLACKJACK!!!";
                labelBust.ForeColor = Color.Yellow;
                hitCount = 10;
            }
            else if (total > 21)
            {
                labelBust.Text = "BUST!!!";
                labelBust.ForeColor = Color.Red;
                hitCount = 10;
            }
        }


        private void buttonDeal_Click_1(object sender, EventArgs e)
        {
            hidePictureBoxes();

            hitCount = 1;

            // Create a deck
            deck = new Deck(imageListCards);

            // create a card object and assign it a value from the cards in the deck
            Card card = deck.drawCard();
            Card card2 = deck.drawCard();
            Card card3 = deck.drawCard();
            Card card4 = deck.drawCard();

            pictureBoxPlayer1.Image = card.FrontImage;
            pictureBoxPlayer1.Visible = true;
            playerTotal = card.blackJackValue();

            pictureBoxPlayer2.Image = card2.FrontImage;
            pictureBoxPlayer2.Visible = true;
            playerTotal += card2.blackJackValue();
            labelPlayerTotal.Text = playerTotal.ToString();

            pictureBoxDealer2.Image = card3.FrontImage;
            pictureBoxDealer2.Visible = true;
            dealerTotal = card3.blackJackValue();
            labelDealerTotal.Text = dealerTotal.ToString();
        }

        private void buttonHit_Click(object sender, EventArgs e)
        {
            Card card = deck.drawCard();

            switch (hitCount)
            {
                case 1:
                    pictureBoxPlayer3.Image = card.FrontImage;
                    pictureBoxPlayer3.Visible = true;
                    playerTotal += card.blackJackValue();
                    break;
                case 2:
                    pictureBoxPlayer4.Image = card.FrontImage;
                    pictureBoxPlayer4.Visible = true;
                    playerTotal += card.blackJackValue();
                    break;
                case 3:
                    pictureBoxPlayer5.Image = card.FrontImage;
                    pictureBoxPlayer5.Visible = true;
                    playerTotal += card.blackJackValue();
                    break;
                case 4:
                    pictureBoxPlayer6.Image = card.FrontImage;
                    pictureBoxPlayer6.Visible = true;
                    playerTotal += card.blackJackValue();
                    break;
                case 5:
                    pictureBoxPlayer7.Image = card.FrontImage;
                    pictureBoxPlayer7.Visible = true;
                    playerTotal += card.blackJackValue();
                    break;
                case 6:
                    pictureBoxPlayer8.Image = card.FrontImage;
                    pictureBoxPlayer8.Visible = true;
                    playerTotal += card.blackJackValue();
                    break;  
            }
            labelPlayerTotal.Text = playerTotal.ToString();

            checkForBust(playerTotal);

            hitCount += 1;
        }

        private void buttonStand_Click(object sender, EventArgs e)
        {
            hitCount = 1;

            Card card = deck.drawCard();

            while (dealerTotal <= 17)
            {
                switch (hitCount)
                {
                    case 1:
                        pictureBoxDealer1.Image = card.FrontImage;
                        pictureBoxDealer1.Visible = true;
                        dealerTotal += card.blackJackValue();
                        break;
                    case 2:
                        pictureBoxDealer3.Image = card.FrontImage;
                        pictureBoxDealer3.Visible = true;
                        dealerTotal += card.blackJackValue();
                        break;
                    case 3:
                        pictureBoxDealer4.Image = card.FrontImage;
                        pictureBoxDealer4.Visible = true;
                        dealerTotal += card.blackJackValue();
                        break;
                    case 4:
                        pictureBoxDealer5.Image = card.FrontImage;
                        pictureBoxDealer5.Visible = true;
                        dealerTotal += card.blackJackValue();
                        break;
                    case 5:
                        pictureBoxDealer6.Image = card.FrontImage;
                        pictureBoxDealer6.Visible = true;
                        dealerTotal += card.blackJackValue();
                        break;
                    case 6:
                        pictureBoxDealer7.Image = card.FrontImage;
                        pictureBoxDealer7.Visible = true;
                        dealerTotal += card.blackJackValue();
                        break;
                    case 7:
                        pictureBoxDealer8.Image = card.FrontImage;
                        pictureBoxDealer8.Visible = true;
                        dealerTotal += card.blackJackValue();
                        break;
                }
                labelDealerTotal.Text = dealerTotal.ToString();

                checkForBust(dealerTotal);

                hitCount += 1;
            }
        }
        
        private void FormMain_Load(object sender, EventArgs e)
        {
           
        }
    }
}
