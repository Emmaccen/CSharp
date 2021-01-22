using System;
using System.Collections.Generic;
using System.Text;

namespace Hello
{
    class DbCommand
    {
        private readonly string instruction;
        public DbCommand(DbConnection database, string instruction)
        {
            if(database != null && !string.IsNullOrEmpty(instruction))
            {
                this.instruction = instruction;
                database.OpenConnection();
                Console.WriteLine(this.instruction);
                database.CloseConnection();
            }
            else
            {
                Console.WriteLine("Null references not allowed for connection to be invoked");
            }
        }
    }
}
