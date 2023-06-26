using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4
{
    class OrderingSystem
    {
        private IConnection connection;
        private ICommand command;
        public void ProcessOrders(DatabaseFactory factory)
        {
            connection = factory.MakeConnection();
            command = factory.MakeCommand();

            connection.Connect();
            command.Execute("'SELECT * FROM Orders'");
            connection.Close();
        }
        public void Connect()
        {

        }
    }
}
