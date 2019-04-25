using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trucoApp.BLL
{
    interface IEnemyStrategy
    {
         Card PlayTurn(List<Card> MyCards, Card table);    
    }
}
