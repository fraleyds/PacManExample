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
        void CheckOutcome();
        int AddLives();
        int AddPoints();
    }
}
