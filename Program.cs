using System;

namespace WebShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t=== WebShop ===\n");

            var client = Client.NewClient();

            Catalog catalog = new Catalog();

            Basket basket = new Basket(catalog.Products);

            PickPoint pickpoint = new PickPoint("Мавзолей В.И. Ленина", "Красная пл., Москва, 109012");

            RetailShop retailShop = new RetailShop("ГУМ", "Красная пл., 3, Москва, 109012");

            HomeDelivery homeDelivery = new HomeDelivery(client.Address);

            PickPointDelivery pickPointDelivery = new PickPointDelivery(pickpoint.Address);

            ShopDelivery shopDelivery = new ShopDelivery(retailShop.Address);

            basket.ProductAdd(0);
            basket.ProductAdd(4);
            basket.ViewBasket();

            Order order = new Order("NN-0001", basket.Content, basket.PriceSumm, client.Name, client.PhoneNumber, homeDelivery.Address);
            
            order.Print();

            //catalog.ViewCatalog();

            //client1.Print();

            //pickpoint.Print();

            //retailShop.Print();

            //pickPointDelivery.DisplayAddress();

            //shopDelivery.DisplayAddress();
        }
    }
}
