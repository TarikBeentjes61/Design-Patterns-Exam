namespace Opgave1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start(){

            SubjectGrader mathGrader = new MathGrader();
            mathGrader.GradeStudent();
            Console.WriteLine();

            SubjectGrader englishGrader = new EnglishGrader();
            englishGrader.GradeStudent();
            Console.WriteLine();

            SubjectGrader programmingGrader = new ProgrammingGrader();
            programmingGrader.GradeStudent();

        }
    }
}