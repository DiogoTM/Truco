using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trucoApp.BLL;

namespace trucoApp.GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        Card myCard, eCard;
        Game myGame;

        private void Main_Load(object sender, EventArgs e)
        {
            Deck myDeck = Game.startNewGame();
            myGame = new Game(myDeck);

            picECard1.BackgroundImage = myGame.Player2.MyCards[0].Picture;
            picECard1.Tag = myGame.Player2.MyCards[0];
            picECard2.BackgroundImage = myGame.Player2.MyCards[1].Picture;
            picECard2.Tag = myGame.Player2.MyCards[1];
            picECard3.BackgroundImage = myGame.Player2.MyCards[2].Picture;
            picECard3.Tag = myGame.Player2.MyCards[2];

            btnMyCard1.BackgroundImage = myGame.Player1.MyCards[0].Picture;
            btnMyCard1.Tag = myGame.Player1.MyCards[0];
            btnMyCard2.BackgroundImage = myGame.Player1.MyCards[1].Picture;
            btnMyCard2.Tag = myGame.Player1.MyCards[1];   
            btnMyCard3.BackgroundImage = myGame.Player1.MyCards[2].Picture;
            btnMyCard3.Tag = myGame.Player1.MyCards[2];          

            picZap.BackgroundImage = myDeck.Vira.Picture;

            dataGridView1.DataSource = myDeck.MyDeck;
        }

        private void btnMyCard1_Click(object sender, EventArgs e)
        {
            myCard = (Card)btnMyCard1.Tag;
            picMyCard.BackgroundImage = myCard.Picture;
            btnMyCard1.Visible = false;
        }

        private void btnMyCard2_Click(object sender, EventArgs e)
        {
            myCard = (Card)btnMyCard2.Tag;
            picMyCard.BackgroundImage = myCard.Picture;
            btnMyCard2.Visible = false;
        }
                             

        private void btnMyCard3_Click(object sender, EventArgs e)
        {
            myCard = (Card)btnMyCard3.Tag;
            picMyCard.BackgroundImage = myCard.Picture;
            btnMyCard3.Visible = false;
        }

        private void btnConfirmPlay_Click(object sender, EventArgs e)
        {
            myGame.Player1.playCard(myCard);

            eCard = myGame.Player2.playturn();

            picECard.BackgroundImage = eCard.Picture;
            myGame.Player2.playCard(eCard);
        }
    }
}
