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

            //client1.Print();

            //Catalog.ViewCatalog();

            //HomeDelivery homeDelivery = new HomeDelivery();
            //homeDelivery.Address = client1.Address;
            //homeDelivery.Run();

            //PickPointDelivery pickPointDelivery = new PickPointDelivery();
            //pickPointDelivery.Address = client1.Address;
            //pickPointDelivery.Run();

            //ShopDelivery shopDelivery = new ShopDelivery();
            //shopDelivery.Address = client1.Address;
            //shopDelivery.Run();
        }
    }
}
