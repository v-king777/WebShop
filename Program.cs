using System;

namespace WebShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t=== WebShop ===\n");

            var client_1 = GetClient();
            client_1.Print();

            Console.WriteLine();

            var client_2 = new Client();
            client_2.Print();
        }

        static Client GetClient()
        {
            var client = new Client();

            client.Id = Guid.NewGuid();
            client.Name = "Vladimir";
            client.PhoneNumber = "+7(900)528-96-08";
            client.Address = "Kirovo-Chepetsk";

            return client;
        }
    }
}
