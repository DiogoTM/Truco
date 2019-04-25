using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        Deck myDeck;
        Game myGame;
        List<PictureBox> enemyDeck = new List<PictureBox>();
        Random rand = new Random();
       
        static int difficultySel = 0;

        private void Main_Load(object sender, EventArgs e)
        {
            myGame = new Game();
            NewGame();
        }
        public void NewGame()

        {
            myDeck = myGame.startNewGame();
            picECard1.Visible = true;
            picECard2.Visible = true;
            picECard3.Visible = true;
            btnMyCard1.Visible = true;
            btnMyCard2.Visible = true;
            btnMyCard3.Visible = true;
            
            myGame.Player2.setStrategy(difficultySel);
            

            picECard1.BackgroundImage = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\pictures\back.jpg");
            picECard1.Tag = myGame.Player2.MyCards[0];
            picECard2.BackgroundImage = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\pictures\back.jpg");
            picECard2.Tag = myGame.Player2.MyCards[1];
            picECard3.BackgroundImage = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\pictures\back.jpg");
            picECard3.Tag = myGame.Player2.MyCards[2];

            btnMyCard1.BackgroundImage = myGame.Player1.MyCards[0].Picture;
            btnMyCard1.Tag = myGame.Player1.MyCards[0];
            btnMyCard2.BackgroundImage = myGame.Player1.MyCards[1].Picture;
            btnMyCard2.Tag = myGame.Player1.MyCards[1];
            btnMyCard3.BackgroundImage = myGame.Player1.MyCards[2].Picture;
            btnMyCard3.Tag = myGame.Player1.MyCards[2];

            picZap.BackgroundImage = myDeck.Vira.Picture;

            enemyDeck.Add(picECard1);
            enemyDeck.Add(picECard2);
            enemyDeck.Add(picECard3);
        }

        private void btnMyCard1_Click(object sender, EventArgs e)
        {
            myCard = (Card)btnMyCard1.Tag;
            picMyCard.BackgroundImage = myCard.Picture;
            btnConfirmPlay.Enabled = true;
            btnMyCard1.Visible = false;
        }

        private void btnMyCard2_Click(object sender, EventArgs e)
        {
            myCard = (Card)btnMyCard2.Tag;
            picMyCard.BackgroundImage = myCard.Picture;
            btnConfirmPlay.Enabled = true;
            btnMyCard2.Visible = false;
        }
                             

        private void btnMyCard3_Click(object sender, EventArgs e)
        {
            myCard = (Card)btnMyCard3.Tag;
            picMyCard.BackgroundImage = myCard.Picture;
            btnConfirmPlay.Enabled = true;
            btnMyCard3.Visible = false;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu myMenu = new Menu(difficultySel);

            myMenu.Show();
            difficultySel = myMenu.Difficulty;
        }
        private void checkTurn()
        {
            if ((myGame.Player1.Rounds - myGame.Player2.Rounds) > 1)
            {
                progMyPoints.Value = myGame.Player1.Points += myGame.RoundWeight;
                NewGame();
            }
            else if ((myGame.Player2.Rounds - myGame.Player1.Rounds) > 1)
            {
                progEPoints.Value = myGame.Player2.Points += myGame.RoundWeight;
                NewGame();
            }
            else
            {

            }                          
                
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            Card winner = myGame.verifyTurn(myCard, eCard);
            if (winner == myCard)
            {
                myGame.Player1.Rounds++;                    
            }
            else
            {
                myGame.Player2.Rounds++;
            }
            picMyCard.BackgroundImage = null;
            picECard.BackgroundImage = null;
            myCard = eCard = null;
            btnContinue.Enabled = false;
            btnConfirmPlay.Enabled = false; 
            checkTurn();
        }

        private void btnConfirmPlay_Click(object sender, EventArgs e)
        {
            myGame.Player1.playCard(myCard);                        
            eCard = myGame.Player2.MyStrategy.PlayTurn(myGame.Player2.MyCards,myCard);
            int indEnemyCard = rand.Next(enemyDeck.Count());
            enemyDeck.ElementAt(indEnemyCard).Visible = false;
            enemyDeck.RemoveAt(indEnemyCard);

            picECard.BackgroundImage = eCard.Picture;
            myGame.Player2.playCard(eCard);
            btnConfirmPlay.Enabled = false;
            btnContinue.Enabled = true;
        }                                             
    }
}
