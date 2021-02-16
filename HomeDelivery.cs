using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop
{
    class HomeDelivery : Delivery
    {
        public HomeDelivery(string address) : base(address) { }

        public override void DisplayAddress()
        {
            base.DisplayAddress();
            Console.WriteLine("на дом по адресу: " + Address);
        }
    }
}
