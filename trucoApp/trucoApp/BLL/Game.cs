using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trucoApp.BLL
{
    class Game
    {
        Player player1;
        Enemy player2;
        int gameType, level;
        string scenery;
        private int roundWeight;

        public Game()
        {
            this.player1 = new Player("Me"); ;
            this.player2 = new Enemy("PC"); ;
            this.gameType = 0;
            this.level = 0;
            this.scenery = "";
            this.RoundWeight = 1;
        }
        public int RoundWeight { get => roundWeight; set => roundWeight = value; }
        public int GameType { get => gameType; set => gameType = value; }
        public int Level { get => level; set => level = value; }
        public string Scenery { get => scenery; set => scenery = value; }
        internal Player Player1 { get => player1; set => player1 = value; }
        internal Enemy Player2 { get => player2; set => player2 = value; }

        public Deck startNewGame()
        {
            Deck myDeck = new Deck();
            player1.MyCards = new List<Card>();
            player2.MyCards = new List<Card>();
            player1.Rounds = 0;
            player2.Rounds = 0;

            for (int i = 1; i < 4; i++)
            {
                Card thisCard = myDeck.drawCard();
                if ((thisCard.Value == myDeck.Vira.Value - 1) || thisCard.Value == 11 && myDeck.Vira.Value == 7)
                {
                    thisCard.IsZap = true;
                    thisCard.Value = 16;
                }                                    
                player1.MyCards.Add(thisCard);  
            }
            for (int i = 1; i < 4; i++)
            {
                Card thisCard = myDeck.drawCard();
                if ((thisCard.Value == myDeck.Vira.Value - 1) || thisCard.Value == 11 && myDeck.Vira.Value == 7)
                {
                    thisCard.IsZap = true;
                    thisCard.Value = 16;
                }
                player2.MyCards.Add(thisCard);
            }


            return myDeck;
        }

        public Card verifyTurn(Card pCard, Card eCard)
        {
            if (pCard.Value > eCard.Value)
            {
                return pCard;                
            }

            else if (pCard.Value == eCard.Value)
            {
                if (pCard.Kind > eCard.Kind)
                {
                    return pCard;
                }
                else
                {
                    return eCard;
                }
            }
            else
            {
                return eCard;
            }
        }
    }
}
