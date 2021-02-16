using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop
{
    class RetailShop : PickPoint
    {
        public RetailShop(string name, string address): base(name, address) {}
        
        public new void Print()
        {
            Console.WriteLine("\n\t< Информация о магазине >\n");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Address: " + address);
        }
    }
}