using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4
{
    class SqlServerConnection : IConnection
    {
        public void Close()
        {
            Console.WriteLine("Closing Sql Server connection.");
        }

        public void Connect()
        {
            Console.WriteLine("Connected to Sql Server database.");
        }
    }
}
