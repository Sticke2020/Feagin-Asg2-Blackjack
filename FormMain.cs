using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feagin_Asg2_Blackjack
{
    public partial class FormMain : Form
    {
        // Deck is global so all methods in FormMain can access the same deck
        Deck deck;

        int hitCount = 1;
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

        private void FormMain_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonDeal_Click_1(object sender, EventArgs e)
        {
            hidePictureBoxes();

            // Create a deck
            deck = new Deck(imageListCards);

            // create a card object and assign it a value from the cards in the deck
            Card card = deck.drawCard();
            Card card2 = deck.drawCard();
            Card card3 = deck.drawCard();
            Card card4 = deck.drawCard();

            pictureBoxPlayer1.Image = card.FrontImage;
            pictureBoxPlayer1.Visible = true;

            pictureBoxPlayer2.Image = card2.FrontImage;
            pictureBoxPlayer2.Visible = true;

            pictureBoxDealer2.Image = card3.FrontImage;
            pictureBoxDealer2.Visible = true;
        }

        private void buttonHit_Click(object sender, EventArgs e)
        {
            Card card = deck.drawCard();

            switch (hitCount)
            {
                case 1:
                    pictureBoxPlayer3.Image = card.FrontImage;
                    pictureBoxPlayer3.Visible = true;
                    break;
                case 2:
                    pictureBoxPlayer4.Image = card.FrontImage;
                    pictureBoxPlayer4.Visible = true;
                    break;
                case 3:
                    pictureBoxPlayer5.Image = card.FrontImage;
                    pictureBoxPlayer5.Visible = true;
                    break;
                case 4:
                    pictureBoxPlayer6.Image = card.FrontImage;
                    pictureBoxPlayer6.Visible = true;
                    break;
                case 5:
                    pictureBoxPlayer7.Image = card.FrontImage;
                    pictureBoxPlayer7.Visible = true;
                    break;
                case 6:
                    pictureBoxPlayer8.Image = card.FrontImage;
                    pictureBoxPlayer8.Visible = true;
                    break;  
            }

            hitCount += 1;
        }

        private void buttonStand_Click(object sender, EventArgs e)
        {

        }
    }
}
