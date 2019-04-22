using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trucoApp.BLL
{
    class Game
    {
        Player player1, player2;
        int gameType, level;
        string scenery;

        public Game(Deck myDeck)
        {
            this.player1 = new Player(myDeck, "Me");
            this.player2 = new Enemy(myDeck, "PC");
            this.gameType = 0;
            this.level = 0;
            this.scenery = "";
        }

        public int GameType { get => gameType; set => gameType = value; }
        public int Level { get => level; set => level = value; }
        public string Scenery { get => scenery; set => scenery = value; }
        internal Player Player1 { get => player1; set => player1 = value; }
        internal Player Player2 { get => player2; set => player2 = value; }

        public static Deck startNewGame()
        {
            Deck myDeck = new Deck();
            return myDeck;
        }
    }
}
