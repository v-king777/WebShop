using System;

namespace WebShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t=== WebShop ===\n");

            var client1 = GetClient();
            client1.SetBirthday(DateTime.Parse("18.02.1983"));
            client1.Print();
        }

        static Client GetClient()
        {
            var client = new Client("Vladimir", "+7(900)528-96-08", "Kirovo-Chepetsk");
            client.id = Guid.NewGuid();

            return client;
        }
    }
}
