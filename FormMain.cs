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
        Hand playerHand = new Hand();
        Hand dealerHand = new Hand();


        int hitCount = 1;
        int playerWins = 0;
        int playerTotal = 0;
        int dealerWins = 0;
        int dealerTotal = 0;
        int gamesPlayed = 0;
        int ties = 0;
        

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


        private void disableButtons()
        {
            buttonHit.Enabled = false;
            buttonStand.Enabled = false;
            buttonDeal.Enabled = true;
        }

        private void showDealersHand()
        {
            if (playerTotal >= 21)
            {
                Card card = deck.drawCard();

                pictureBoxDealer1.Image = card.FrontImage;
                pictureBoxDealer1.Visible = true;
                dealerTotal += card.blackJackValue();
                dealerHand.addCard(card);
                dealerTotal = dealerHand.getBlackJackTotal();
                labelDealerTotal.Text = dealerTotal.ToString();

                disableButtons();
                checkWinner();
            }
        }

       private void blackJackOrBust(int total)
        {
            if (total == 21)
            {
                labelBust.Text = "BLACKJACK!!!";
                labelBust.ForeColor = Color.Black;
                hitCount = 20;
            }
            else if (total > 21)
            {
                labelBust.Text = "BUST!!!";
                labelBust.ForeColor = Color.Red;
                hitCount = 30;
            }
        }

        private void resetSpread()
        {
            labelBust.Text = "";
            labelWinner.Text = "";
            buttonHit.Enabled = true;
            buttonStand.Enabled=true;
            pictureBoxDealer1.Image = imageListCards.Images[52];
            labelDealerWins.Text = dealerWins.ToString();
            labelPlayerWins.Text = playerWins.ToString();
            labelTies.Text = ties.ToString();
            labelTotalGames.Text = gamesPlayed.ToString();
            playerHand.clearHand();
            dealerHand.clearHand();
            gamesPlayed += 1;
            buttonDeal.Enabled = false;
        }

        private void checkWinner()
        {
            if (playerTotal > 21)
            {
                labelWinner.Text = "DEALER WINS!!";
                dealerWins += 1;
            }
            else if (dealerTotal > 21)
            {
                labelWinner.Text = "YOU WIN!!!";
                playerWins += 1;
            }
            else if (playerTotal > dealerTotal)
            {
                labelWinner.Text = "YOU WIN!!!";
                playerWins += 1;
            }
            else if (playerTotal < dealerTotal)
            {
                labelWinner.Text = "DEALER WINS!!";
                dealerWins += 1;
            }
            else
            {
                labelWinner.Text = "IT'S A TIE!!";
                ties += 1;
            }
        }

        private void buttonDeal_Click_1(object sender, EventArgs e)
        {
            hidePictureBoxes();

            resetSpread();

            hitCount = 1;

            // Create a deck
            deck = new Deck(imageListCards);

            // create a card object and assign it a value from the cards in the deck
            Card card = deck.drawCard();
            Card card2 = deck.drawCard();
            Card card3 = deck.drawCard();
            

            pictureBoxPlayer1.Image = card.FrontImage;
            pictureBoxPlayer1.Visible = true;
            playerTotal = card.blackJackValue();
            playerHand.addCard(card);
            

            pictureBoxPlayer2.Image = card2.FrontImage;
            pictureBoxPlayer2.Visible = true;
            playerTotal += card2.blackJackValue();
            playerHand.addCard(card2);
            playerTotal = playerHand.getBlackJackTotal();
            blackJackOrBust(playerTotal);
            showDealersHand();
            labelPlayerTotal.Text = playerTotal.ToString();

            pictureBoxDealer2.Image = card3.FrontImage;
            pictureBoxDealer2.Visible = true;
            dealerTotal = card3.blackJackValue();
            dealerHand.addCard(card3);
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
            playerHand.addCard(card);
            playerTotal = playerHand.getBlackJackTotal();
            labelPlayerTotal.Text = playerTotal.ToString();

            blackJackOrBust(playerTotal);
            showDealersHand();

            hitCount += 1;
        }

        private void buttonStand_Click(object sender, EventArgs e)
        {
            hitCount = 1;

            while (dealerTotal <= 16)
            {
                Card card = deck.drawCard();

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
                dealerHand.addCard(card);
                dealerTotal = dealerHand.getBlackJackTotal();
                labelDealerTotal.Text = dealerTotal.ToString();

                blackJackOrBust(dealerTotal);
                
                hitCount += 1;
            }

            disableButtons();
            checkWinner();
        }
        
        private void FormMain_Load(object sender, EventArgs e)
        {
           
        }
    }
}
