using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4
{
    class SqlDatabaseFactory : DatabaseFactory
    {
        public override ICommand MakeCommand()
        {
            return new SqlServerCommand();
        }

        public override IConnection MakeConnection()
        {
            return new SqlServerConnection();
        }
    }
}
