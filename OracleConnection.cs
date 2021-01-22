using System;
using System.Collections.Generic;
using System.Text;

namespace Hello
{
    class OracleConnection : DbConnection
    {
        private readonly string connectionType;
        public OracleConnection(string connectionType) : base(connectionType)
        {
            this.connectionType = connectionType;

        }

        public override void CloseConnection()
        {
            Console.WriteLine("Closing connection to {0} datebase...", connectionType);
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Connecting to {0} datebase...", connectionType);
        }
    }
}
