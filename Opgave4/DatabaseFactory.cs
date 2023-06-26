using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4
{
    class DatabaseFactory
    {
        public virtual IConnection MakeConnection()
        {
            return new SqlServerConnection();
        }
        public virtual ICommand MakeCommand()
        {
            return new SqlServerCommand();
        }
    }
}
