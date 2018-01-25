using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPacman
{
   public class GameController
    {   
        //Instantiate 
        public static new GameService game = new GameService();

        public static void Begin()
        {
            //Connecting methods to service
            game.ReadFileText();
            game.AddPoints();
            game.AddLives();
            game.GameConsole();
        }
    }
}
