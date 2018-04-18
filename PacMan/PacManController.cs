using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan
{
    public class PacManController
    {
        //Instantiates Service in the Controller
        private static PacManService service = new PacManService();

        public static void RunGame()
        {
            var actionSequence = service.ReadFile();

            var incrementer = 0;

            var length = actionSequence.Length;
            var gameLoop = true;

            while (gameLoop)
            {
                var action = actionSequence[incrementer].ToLower();
                service.AddPoints(action);
                service.AddLives();
                service.LoseLife(action);

                //Ends the loop if Pac-Man is out of lives
                if (!service.CheckAlive())
                    gameLoop = false;

                //Ends the loop if the full array has been read
                incrementer++;
                if (incrementer == length - 1)
                    gameLoop = false;
            }

            service.FinalOutput();
        }
    }
}
