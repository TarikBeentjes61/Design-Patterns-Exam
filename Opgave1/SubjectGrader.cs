using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1
{
    abstract class SubjectGrader
    {
        public void GradeStudent() 
        {
            Console.WriteLine("Grading started...");
            bool fulfilled = CheckRequirements();
            int grade = Calculate();
            GiveFeedback(fulfilled, grade);
            Console.WriteLine("Grading completed.");
        }
        public virtual bool CheckRequirements() { return false; }
        public virtual int Calculate() { return 0; }
        public void GiveFeedback(bool fulfilled, int grade) 
        {
            if(fulfilled)
            {
                Console.WriteLine($"Feedback: all requirements are fulfilled, your score is {grade}");
            }
            else
            {
                Console.WriteLine("Feedback: not all requirements are fulfilled");
            }
        }
    }
}
