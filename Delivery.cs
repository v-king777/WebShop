using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop
{
    abstract class Delivery
    {
        public string Address { get; set; }
        public abstract void Run();
    }

    class HomeDelivery : Delivery
    {
        public override void Run()
        {
            Console.WriteLine("Выполняется доставка на дом по адресу: " + Address);
        }
    }

    class PickPointDelivery : Delivery
    {
        public override void Run()
        {
            Console.WriteLine("Выполняется доставка в пункт выдачи по адресу: " + Address);
        }
    }

    class ShopDelivery : Delivery
    {
        public override void Run()
        {
            Console.WriteLine("Выполняется доставка в магазин по адресу: " + Address);
        }
    }
}
