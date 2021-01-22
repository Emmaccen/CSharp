using System;
using System.Collections;
using System.Collections.Generic;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            int converted;
            bool isConverted = int.TryParse("unconvertable", out converted);
            if (isConverted)
                Console.WriteLine("How come it was able to convert");
            else
                Console.WriteLine("heheheheh, errors everywhere!");

            Customers james = new Customers("Big Man");
            james.orders.Add(new Orders("Cappuccino", 1500));
            james.Promote(james, 20);
            Console.WriteLine("Level : " + james.Level);
            Console.WriteLine("Level : " + james.orders[0].Item);

            var person = new Person(new DateTime(1998, 06, 19));
            Console.WriteLine(person.Age);
            Console.WriteLine(person.Birthdate);
            Console.WriteLine(DateTime.Today);

            HttpCookie session = new HttpCookie();
            session["today"] = DateTime.Now.AddDays(2);
            TimeSpan daysLeft = session["today"] - DateTime.Now;
            Console.WriteLine("Cookie Expires in : {0} day(s)",daysLeft.TotalDays);


            //...
            Installer installer = new Installer(new Logger());
            installer.Install();

            Car car = new Car("Limosine");

            Text text = new Text();
            Shape shape = text;

            Stack stack = new Stack();
            stack.Push(1);

            OracleConnection oracle = new OracleConnection("Oracle");
            oracle.OpenConnection();

            DbMigrator migrator = new DbMigrator(new ConsoleLogger());
            migrator.Migrate();
        }
    }
}
