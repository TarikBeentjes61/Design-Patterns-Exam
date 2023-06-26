﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave2
{
    class ZombieApocalypse : LaserGame
    {
        private IScoringMechanism scoringMechanism;
        public override void PlayGame()
        {
            Console.WriteLine("Playing laser game...");
            int score = scoringMechanism.CalculateScore();
            Console.WriteLine($"Score: {score}");

        }
        public override void ChangeScoringMechanism(IScoringMechanism mechanism)
        {
            scoringMechanism = mechanism;
        }
        public ZombieApocalypse()
        {
            scoringMechanism = new StandaardMechanism();
        }
    }
}
