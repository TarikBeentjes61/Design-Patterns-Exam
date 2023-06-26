namespace Opgave4
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
            OrderingSystem system = new OrderingSystem();

            PrintHeader("Ordering system using an SQL database");
            DatabaseFactory sqlFactory = new SqlDatabaseFactory();
            system.ProcessOrders(sqlFactory);

            Console.WriteLine();

            PrintHeader("Ordering system using an Oracle database");
            DatabaseFactory oracleFactory = new OracleDatabaseFactory();
            system.ProcessOrders(oracleFactory);
        }
        void PrintHeader(string header)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(header);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}