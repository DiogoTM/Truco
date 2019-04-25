using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trucoApp.BLL
{
    class Enemy : Player
    {

        private IEnemyStrategy myStrategy;


        public Enemy(string name) : base(name)
        {
           
        }

        Random rand = new Random();

        public void setStrategy(int difficulty)
        {
            switch(difficulty)
            {
                case 0:
                    MyStrategy = new dumbStrategy();
                    break;
                case 1:     
                    MyStrategy = new regularStrategy();
                    break;
                case 2:         
                    MyStrategy = new smartStrategy();
                    break;                                        
            }

        }
        internal IEnemyStrategy MyStrategy { get => myStrategy; set => myStrategy = value; }                                 

    }
}
