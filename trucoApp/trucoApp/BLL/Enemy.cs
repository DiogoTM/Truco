using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trucoApp.BLL
{
    class Enemy : Player
    {

        public Enemy(Deck myDeck, string name) : base(myDeck, name)
        {
           
        }
        Random rand = new Random();
        public Card playturn()
        {
            int drawCard = rand.Next(MyCards.Count);
            Card card = new Card(MyCards[drawCard].Value, MyCards[drawCard].Kind, MyCards[drawCard].Picture, MyCards[drawCard].IsZap);
            MyCards.RemoveAt(drawCard);
            return card;                                
        }

    }
}
