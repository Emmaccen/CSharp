using System;
using System.Collections.Generic;
using System.Text;

namespace Hello
{
    class Person
    {
        public DateTime Birthdate {get; private set;}

        public Person(DateTime birthdate)
        {
            this.Birthdate = birthdate;
        }

        public int Age
        {
            get 
            {
                var age = DateTime.Now - Birthdate;
                return (int)age.TotalDays / 365;
            }
           

        }
    }
}
