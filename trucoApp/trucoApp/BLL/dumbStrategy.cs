using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace trucoApp.BLL
{
    class dumbStrategy : IEnemyStrategy
    {
      
        public Card PlayTurn(List<Card> MyCards, Card table)
        {
            Random rand = new Random();
            int drawCard = rand.Next(MyCards.Count);
            Card card = new Card(MyCards[drawCard].Value, MyCards[drawCard].Kind, MyCards[drawCard].Picture, MyCards[drawCard].IsZap);
            MyCards.RemoveAt(drawCard);
            return card;
        }

    }
}
