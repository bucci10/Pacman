using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FinalPacman
{
    public class GameService : IGameService
    {

        public static new Pacman packman = new Pacman();

        string[] getTextFile;

        public string[] ReadFileText()
        {
            string textFile = @"C:\Users\Ciprian\source\repos\FinalPacman\KataPacman-seq.txt";
            string[] textArray = File.ReadAllText(textFile).Split(',');
            getTextFile = textArray;
           
            return getTextFile;
        }

        public int AddPoints()
        {
            int score = 5000;

            foreach ( var item in getTextFile)
            {
                switch(item.ToLower())
                {
                    case "dot":
                        score += 10;
                        break;
                    case "cherry":
                        score += 100;
                        break;
                    case "strawberry":
                        score += 300;
                        break;
                    case "orange":
                        score += 500;
                        break;
                    case "apple":
                        score += 700;
                        break;
                    case "melon":
                        score += 1000;
                        break;
                    case "galaxian":
                        score += 2000;
                        break;
                    case "bell":
                        score += 3000;
                        break;
                    case "key":
                        score += 5000;
                        break;

                    case "vulnerableghost":
                        score += EatVulnerableGhost();
                        packman.GhostsEaten++;
                        break;

                    case "invincibleghost":
                        packman.Lives -= 1;
                        break;
                }
            }

            int EatVulnerableGhost()
            {
                var firstGhost = 200;

                for (int i = 0; i < packman.GhostsEaten; i++)
                {
                    firstGhost *= 2;
                }
                return firstGhost;
            }

            return packman.Points = score;
        }




        public int AddLives()
        {
            int AddLives = 0;
            int lives = 3;

            for (int i  = packman.Points; i > 10000; i -=10000)
            {
                AddLives += 1;
                lives += 1;
            }

            packman.Lives = lives;
            return packman.LivesGained = AddLives;

           
        }


        public void GameConsole()
        {
            if(packman.Lives < 0)
            {
                Console.WriteLine(" The game has ended " + packman.Points + packman.Lives);
                Console.Read();
            }
            else
            {
                Console.WriteLine(" You've beaten the game with a score of " + packman.Points + " and you have gained " + packman.LivesGained);
                Console.ReadLine();
            }

            
        }

        
    }
}
