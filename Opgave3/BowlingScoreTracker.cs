using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3
{
    class BowlingScoreTracker
    {
        private List<string> players;
        private Dictionary<string, List<int>> scores;

        private static BowlingScoreTracker instance;
        public BowlingScoreTracker()
        {
            players = new List<string>(); 
            scores = new Dictionary<string, List<int>>();
        }
        public static BowlingScoreTracker GetInstance()
        {
            if(instance == null)
                instance = new BowlingScoreTracker();
            return instance;
        }
        public void AddPlayer(string name)
        {
            players.Add(name);
            Console.WriteLine($"added player {name}");
        }
        public void AddScore(string name, int score)
        {
            if(!scores.ContainsKey(name))
                scores.Add(name, new List<int>());

            scores[name].Add(score);
            
            Console.WriteLine($"added score {score} for player {name}");
        }
        public void DisplayTotalScores()
        {
            foreach(KeyValuePair<string, List<int>> keyValuePair in scores)
            {
                Console.WriteLine($"Total score for player {keyValuePair.Key}: {keyValuePair.Value.Sum()}");
            }
        }
    }
}
