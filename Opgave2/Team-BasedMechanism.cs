using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave2
{
    class Team_BasedMechanism : IScoringMechanism
    {
        public int CalculateScore() 
        {
            Console.WriteLine("Calculating score based on team-based scoring strategy");
            return 25;
        }
    }
}
