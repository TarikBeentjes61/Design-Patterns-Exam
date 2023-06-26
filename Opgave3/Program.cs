namespace Opgave3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            BowlingScoreTracker tracker1 = BowlingScoreTracker.GetInstance();
            PrintHeader("tracker #1");
            tracker1.AddPlayer("David");
            tracker1.AddScore("David", 8);
            tracker1.AddScore("David", 5);
            tracker1.AddScore("David", 2);
            Console.WriteLine();

            BowlingScoreTracker tracker2 = BowlingScoreTracker.GetInstance();
            PrintHeader("tracker #2");
            tracker2.AddPlayer("Sarah");
            tracker2.AddScore("Sarah", 4);
            tracker2.AddScore("Sarah", 9);
            tracker2.AddScore("Sarah", 3);
            Console.WriteLine();

            BowlingScoreTracker tracker3 = BowlingScoreTracker.GetInstance();
            PrintHeader("display total scores with tracker #3");
            tracker3.DisplayTotalScores();
        }
        void PrintHeader(string header)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(header);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}