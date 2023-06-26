namespace Opgave2
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
            PrintHeader("Capture The Flag");
            LaserGame captureTheFlagGame = new CaptureTheFlag();
            captureTheFlagGame.PlayGame();

            Console.WriteLine();

            PrintHeader("Zombie Apocalypse");
            LaserGame zombieGame = new ZombieApocalypse();
            zombieGame.PlayGame();

            Console.WriteLine();

            PrintHeader("Change scoring mechanism of zombie game");
            zombieGame.ChangeScoringMechanism(new Target_BasedMechanism());
            zombieGame.PlayGame();
        }
        void PrintHeader(string header)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(header);
            Console.ForegroundColor= ConsoleColor.White;
        }
    }
}