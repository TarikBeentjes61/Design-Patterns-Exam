using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4
{
    class SqlServerCommand : ICommand
    {
        public void Execute(string query)
        {
            Console.WriteLine($"Executing query {query} on SQL Server Database");
        }
    }
}
