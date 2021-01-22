using System;
using System.Collections.Generic;
using System.Text;

namespace Hello
{
    abstract class DbConnection
    {
        private readonly string connection;
        private readonly TimeSpan timeout;

        public DbConnection(string connection)
        {
            if(!string.IsNullOrEmpty(connection))
            {
                this.connection = connection;
            }
            else
            {
                Console.WriteLine("Please provide a valid connection");
            }
        }
        public abstract void OpenConnection();
        public abstract void CloseConnection();
        public void DoSomething()
        {
            Console.WriteLine("implementation details");
        }
    }
}
