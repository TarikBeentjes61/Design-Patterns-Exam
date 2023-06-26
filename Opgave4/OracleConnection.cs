using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4
{
    class OracleConnection : IConnection
    {
        public void Close()
        {
            Console.WriteLine("Closing Oracle connection.");
        }

        public void Connect()
        {
            Console.WriteLine("Connected to Oracle database.");
        }
    }
}
