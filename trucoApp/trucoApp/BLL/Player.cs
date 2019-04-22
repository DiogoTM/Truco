using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trucoApp.BLL;

namespace trucoApp.BLL
{
    class Player
    {
        List<Card> myCards;
        int points, rounds, games;
        string name;
        bool isPlay;

        public Player(Deck myDeck, string name)
        {
            this.myCards = new List<Card>();
            for (int i = 1; i < 4; i++)
            {
                Card thisCard = myDeck.drawCard();
                if ((thisCard.Value == myDeck.Vira.Value-1) || thisCard.Value == 11 && myDeck.Vira.Value == 7)
                {
                    thisCard.IsZap = true;
                }                         
                this.myCards.Add(thisCard);

            }                                                  
            this.points = 0;
            this.rounds = 0;
            this.games = 0;
            this.name = name;
            this.isPlay = false;
        }

        public int Points { get => points; set => points = value; }
        public int Rounds { get => rounds; set => rounds = value; }
        public int Games { get => games; set => games = value; }
        public string Name { get => name; set => name = value; }
        public bool IsPlay { get => isPlay; set => isPlay = value; }
        internal List<Card> MyCards { get => myCards; set => myCards = value; }

        public Card playCard(Card myCard)
        {                                                                             
            Card card = new Card(myCard.Value, myCard.Kind, myCard.Picture, myCard.IsZap);
            myCards.Remove(myCard);
            return myCard;
        }

        public void skipTurn()
        {

        }

        public void skipRoung()
        {

        }

        public void giveGame()
        {

        }



    }
}
