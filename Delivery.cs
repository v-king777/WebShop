using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop
{
    abstract class Delivery
    {
        public string Address { get; set; }
        
        public virtual void DisplayAddress()
        {
            Console.Write("Доставка ");
        }
    }

    class HomeDelivery : Delivery
    {
        public override void DisplayAddress()
        {
            base.DisplayAddress();
            Console.WriteLine("на дом по адресу: " + Address);
        }
    }

    class PickPointDelivery : Delivery
    {
        public override void DisplayAddress()
        {
            base.DisplayAddress();
            Console.WriteLine("в пункт выдачи по адресу: " + Address);
        }
    }

    class ShopDelivery : Delivery
    {
        public override void DisplayAddress()
        {
            base.DisplayAddress();
            Console.WriteLine("в магазин по адресу: " + Address);
        }
    }
}
