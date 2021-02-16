using System;

namespace WebShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t=== WebShop ===\n");

            var client1 = Client.NewClient();

            Catalog catalog = new Catalog();

            Basket basket = new Basket(catalog.Products);

            PickPoint pickpoint = new PickPoint("Мавзолей В.И. Ленина", "Красная пл., Москва, 109012");
            
            RetailShop retailShop = new RetailShop("ГУМ", "Красная пл., 3, Москва, 109012");
            
            Order<string, object[]> order1 = new Order<string, object[]>("NN-0001", basket.Content);
            
            order1.Print();
            
            //client1.Print();

            //catalog.ViewCatalog();
            
            //basket.ProductAdd(0);
            //basket.ProductAdd(4);
            //basket.ViewBasket();
            
            //pickpoint.Print();
            
            //retailShop.Print();

            //HomeDelivery homeDelivery = new HomeDelivery();
            //homeDelivery.Address = client1.Address;

            //PickPointDelivery pickPointDelivery = new PickPointDelivery();
            //pickPointDelivery.Address = pickpoint.Address;

            //ShopDelivery shopDelivery = new ShopDelivery();
            //shopDelivery.Address = retailShop.Address;
            
        }
    }
}
