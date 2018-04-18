using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan
{
    public class PacManService : IPacManService
    {
        //Instantiates Pac-Man as an object with the given number of starting lives and points
        private PacMan pacMan = new PacMan(3, 5000);

        public string[] ReadFile()
        {
            const string text = @"..\..\..\KataPacman-seq.txt";
            var contents = File.ReadAllText(text).Split(',');
            return contents;
        }

        public void FinalOutput()
        {
            Console.WriteLine($"Pac-Man ended the game with {pacMan.Points} points and {pacMan.Lives} lives, and gained {pacMan.GainedLives} extra lives.");
        }

        public bool CheckAlive()
        {
            return pacMan.Lives >= 0;
        }

        public void AddLives()
        {
            if (pacMan.PointIncrementer >= 10000)
            {
                pacMan.Lives++;
                pacMan.GainedLives++;
                pacMan.PointIncrementer -= 10000;
            }
        }

        public void LoseLife(string action)
        {
            if (action == "invincibleghost")
                pacMan.Lives--;
        }

        public void AddPoints(string action)
        {
            int pointIncrease;

            switch (action)
            {
                case "dot":
                    pointIncrease = 10;
                    break;
                case "cherry":
                    pointIncrease = 100;
                    break;
                case "strawberry":
                    pointIncrease = 300;
                    break;
                case "orange":
                    pointIncrease = 500;
                    break;
                case "apple":
                    pointIncrease = 700;
                    break;
                case "melon":
                    pointIncrease = 1000;
                    break;
                case "galaxian":
                    pointIncrease = 2000;
                    break;
                case "bell":
                    pointIncrease = 3000;
                    break;
                case "key":
                    pointIncrease = 5000;
                    break;
                case "vulnerableghost":
                    pointIncrease = 200 * pacMan.GhostModifier;
                    pacMan.GhostModifier *= 2;
                    break;
                default:
                    pointIncrease = 0;
                    break;
            }

            pacMan.Points += pointIncrease;
            pacMan.PointIncrementer += pointIncrease;
        }
    }
}
