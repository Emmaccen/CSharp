using System;

namespace Hello
{
    class Text : Shape
    {
        public int FontSize { get; set; }

        public void Print()
        {
            Console.WriteLine("Printing papers...");
        }
    }
}
