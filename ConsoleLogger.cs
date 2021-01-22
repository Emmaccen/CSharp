using System;

namespace Hello
{
    class ConsoleLogger : ILogger
    {
        public void Error(string errorMessage)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(errorMessage);
        }

        public void InfoLog(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            //reset back to white
            Console.ForegroundColor = (ConsoleColor) 15;
        }
    }
}
