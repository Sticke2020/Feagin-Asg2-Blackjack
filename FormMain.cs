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
            // 2 of clubs
            Card card = new Card(2, Card.CardSuit.Clubs, 4);

            pictureBoxDealer2.Image = imageListCards.Images[card.ImageIndex];

        }
    }
}
