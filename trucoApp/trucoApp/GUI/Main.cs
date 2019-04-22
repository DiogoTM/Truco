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

        private void Main_Load(object sender, EventArgs e)
        {
            Deck myDeck = Game.startNewGame();
            Game myGame = new Game(myDeck);

            btnECard1.BackgroundImage = myGame.Player2.MyCards[0].Picture;
            btnECard2.BackgroundImage = myGame.Player2.MyCards[1].Picture;
            btnECard3.BackgroundImage = myGame.Player2.MyCards[2].Picture;

            btnMyCard1.BackgroundImage = myGame.Player1.MyCards[0].Picture;
            btnMyCard2.BackgroundImage = myGame.Player1.MyCards[1].Picture;
            btnMyCard3.BackgroundImage = myGame.Player1.MyCards[2].Picture;

            picZap.BackgroundImage = myDeck.Vira.Picture;

            dataGridView1.DataSource = myDeck.MyDeck;
        }

    }
}
