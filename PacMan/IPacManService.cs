using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan
{
    public interface IPacManService
    {
        string[] ReadFile();
        bool CheckAlive();
        void AddLives();
        void AddPoints(string action);
        void LoseLife(string action);
        void FinalOutput();
    }
}
