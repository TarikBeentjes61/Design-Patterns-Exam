using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4
{
    class OracleDatabaseFactory : DatabaseFactory
    {
        public override ICommand MakeCommand()
        {
            return new OracleCommand();
        }

        public override IConnection MakeConnection()
        {
            return new OracleConnection();
        }
    }
}
