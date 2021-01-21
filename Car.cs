using System;
using System.Collections.Generic;
using System.Text;

namespace Hello
{
    class Car : Vehicle
    {
        public Car(string name) : base(name)
        {
            Console.WriteLine("In Car class");
        }
    }
}
