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
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            // Create a deck
            Deck deck = new Deck();

            // create a card object and assign it a value from the cards in the deck
            Card card = deck.drawCard();
            Card card2 = deck.drawCard();

            label1.Text = card.ToString();
            pictureBoxDealer1.Image = imageListCards.Images[card.ImageIndex];


            label2.Text = card2.ToString();
            pictureBoxDealer2.Image = imageListCards.Images[card2.ImageIndex];

        }
    }
}
