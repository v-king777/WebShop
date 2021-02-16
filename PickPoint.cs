using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop
{
    class PickPoint
    {
        protected string name;
        protected string address;

        public PickPoint(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public string Name
        {
            get { return name; }
        }

        public string Address
        {
            get { return address; }
        }

        public virtual void Print()
        {
            Console.WriteLine("\n\t< Информация о точке доставки >\n");
            Console.WriteLine("Название: " + name);
            Console.WriteLine("Адрес: " + address);
        }
    }
}
