using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop
{
    abstract class Delivery
    {
        public string Address { get; set; }
        public virtual void Run()
        {
            Console.Write("Выполняется доставка ");
        }
    }

    class HomeDelivery : Delivery
    {
        public override void Run()
        {
            base.Run();
            Console.WriteLine("на дом по адресу: " + Address);
        }
    }

    class PickPointDelivery : Delivery
    {
        public override void Run()
        {
            base.Run();
            Console.WriteLine("в пункт выдачи по адресу: " + Address);
        }
    }

    class ShopDelivery : Delivery
    {
        public override void Run()
        {
            base.Run();
            Console.WriteLine("в магазин по адресу: " + Address);
        }
    }
}
