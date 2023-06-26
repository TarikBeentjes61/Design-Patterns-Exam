using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1
{
     class ProgrammingGrader : SubjectGrader
    {
        public override bool CheckRequirements()
        {
            Console.WriteLine("Checking if all Programming requirements are fulfilled");
            return false;
        }
        public override int Calculate()
        {
            Console.WriteLine("Calculating Programming Score...");
            return 0;
        }
    }
}
