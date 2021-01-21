using System;
using System.Collections.Generic;
using System.Text;

namespace Hello
{
    class Shape
    {
        public int PointA { get; set; }
        public int PointB { get; set; }

        public void Move()
        {
            Console.WriteLine("Moving from one point to the other");
        }
    }
}
