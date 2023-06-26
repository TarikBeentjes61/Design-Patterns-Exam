using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1
{
    class EnglishGrader : SubjectGrader
    {
        public override bool CheckRequirements()
        {
            Console.WriteLine("Checking if all English requirements are fulfilled");
            return true;
        }
        public override int Calculate()
        {
            Console.WriteLine("Calculating English Score...");
            return 92;
        }
    }
}
