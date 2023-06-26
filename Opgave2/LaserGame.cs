using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave2
{
    abstract class LaserGame
    {
        public abstract void PlayGame();
        public abstract void ChangeScoringMechanism(IScoringMechanism mechanism);

    }
}
