using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop
{
    class PickPointDelivery : Delivery
    {
        public PickPointDelivery(string address) : base(address) { }

        public override void DisplayAddress()
        {
            base.DisplayAddress();
            Console.WriteLine("в пункт выдачи по адресу: " + Address);
        }
    }
}
