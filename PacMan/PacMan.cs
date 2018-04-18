using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan
{
    public class PacMan
    {
        public PacMan(int startLives, int startPoints)
        {
            Lives = startLives;
            Points = startPoints;
            PointIncrementer = Points;
            GhostModifier = 1;
            GainedLives = 0;
        }

        public int Lives { get; set; }
        public int Points { get; set; }
        public int PointIncrementer { get; set; }
        public int GhostModifier { get; set; }
        public int GainedLives { get; set; }
    }
}
