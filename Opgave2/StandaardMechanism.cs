using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave2
{
    class StandaardMechanism : IScoringMechanism
    {
        public int CalculateScore()
        {
            Console.WriteLine("Calculating score based on standard scoring strategy");
            return 10;
        }
    }
}
