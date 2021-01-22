using System;
using System.Collections.Generic;
using System.Text;

namespace Hello
{
    class Vehicle
    {
        private readonly string Name;

        public Vehicle(string name)
        {
            Console.WriteLine("Setting vehicle name ...");
           this.Name = name;
        }
    }
}
