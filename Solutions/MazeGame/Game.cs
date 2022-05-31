using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MazeGame
{
    internal class Game
    {
        public void Start()
        {
            string[,] grid =
            {
              {" ","=","="},
              {" ","=","="},
              {" "," ","X"},
            
            };
            World myWorld = new World(grid);
            myWorld.Draw();

            Player currentPlayer = new Player(0,0);
            currentPlayer.Draw();


            //WriteLine("\n\nPress any key to exit..");
            ReadKey(true);
        }
    }
}
