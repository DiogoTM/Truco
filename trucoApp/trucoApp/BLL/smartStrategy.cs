using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trucoApp.BLL
{
    class smartStrategy : IEnemyStrategy

    {
        public Card PlayTurn(List<Card> MyCards, Card table)
        {
            Card card;

            foreach (Card cards in MyCards)
            {
                if (!cards.IsZap || cards.Value > table.Value)
                {
                    card = new Card(cards.Value, cards.Kind, cards.Picture, cards.IsZap);
                    MyCards.Remove(cards);
                    return card;
                }
            }
            Random rand = new Random();
            int drawCard = rand.Next(MyCards.Count);
            card = new Card(MyCards[drawCard].Value, MyCards[drawCard].Kind, MyCards[drawCard].Picture, MyCards[drawCard].IsZap);
            MyCards.RemoveAt(drawCard);
            return card;
        }
    }
}
