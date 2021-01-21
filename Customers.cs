using System;
using System.Collections.Generic;
using System.Text;

namespace Hello
{
    class Orders
    {
       public string Item;
        int Price;
        public Orders(string item, int price)
        {
            this.Item = item;
            this.Price = price;
        }
    }
    class Customers
    {
        public string Name;
        public readonly List<Orders> orders = new List<Orders>();
        public int Level = 0;
        public Customers()
        {
            Console.WriteLine("In base constructor");
        }
        public Customers(string name)
            // this runs the base constructor
            : this()
        {
            this.Name = name;
        }
        public Customers(string name, List<Orders> orders)
            : this()
        {
            this.Name = name;
        }

        public void Promote(Customers customer, int level)
        {
            customer.Level = level;
        }
    }
}
