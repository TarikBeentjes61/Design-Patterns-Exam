using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1
{
    class MathGrader : SubjectGrader
    {
        public override bool CheckRequirements()
        {
            Console.WriteLine("Checking if all Math requirements are fulfilled");
            return true;
        }
        public override int Calculate()
        {
            Console.WriteLine("Calculating Math Score...");
            return 38;
        }
    }
}
