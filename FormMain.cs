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

            // 2 of clubs
            Card card = new Card(2, Card.CardSuit.Clubs, 4);
            label1.Text = card.ToString();

            pictureBoxDealer1.Image = imageListCards.Images[card.ImageIndex];


            Card card2 = new Card(3, Card.CardSuit.Diamonds, 9);
            label2.Text = card2.ToString();

            pictureBoxDealer2.Image = imageListCards.Images[card2.ImageIndex];

        }
    }
}
