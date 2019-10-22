using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Controller
    {
        private Board Game;
        private Player P1,P2;
        public void PlayGame()
        {
            Game.PrintGame();
            while(true)
            {
                Console.WriteLine(P1.GetName());
                P1.PickBall(Game);
                Game.PrintGame();
                if(Game.IsGameOver())
                {
                    Console.WriteLine(P1.GetName()+" lose!");
                    break;
                }
                Console.WriteLine(P2.GetName());
                P2.PickBall(Game);
                Game.PrintGame();
                if (Game.IsGameOver())
                {
                    Console.WriteLine(P2.GetName()+" lose!");
                    break;
                }
            }
        }
        public Controller()
        {
            this.Game = new Board(3,4,6);
            this.P1 = new Player("The fisrt person");
            this.P2 = new Player("The second person");
        }

    }
}
