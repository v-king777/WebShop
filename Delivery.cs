using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop
{
    abstract class Delivery
    {
        protected string address;

        public Delivery(string address)
        {
            this.address = address;
        }

        public string Address
        {
            get { return address; }
        }

        public virtual void DisplayAddress()
        {
            Console.Write("Доставка ");
        }
    }
}
