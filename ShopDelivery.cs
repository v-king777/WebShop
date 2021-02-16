using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop
{
    class ShopDelivery : Delivery
    {
        public ShopDelivery(string address) : base(address) { }

        public override void DisplayAddress()
        {
            base.DisplayAddress();
            Console.WriteLine("в магазин по адресу: " + Address);
        }
    }
}
