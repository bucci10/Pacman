using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPacman
{
    interface IGameService
    {
        string[] ReadFileText();
        int AddPoints();
        int AddLives();
        void GameConsole();

    }
}
