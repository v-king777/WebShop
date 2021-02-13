using System;

namespace WebShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t=== WebShop ===\n");

            var client1 = NewClient();
            client1.Print();
        }

        static Client NewClient()
        {
            var client = new Client();

            client.Id = Guid.NewGuid();

            Console.WriteLine("Добро пожаловать!");

            Console.Write("Введите своё имя: ");
            client.Name = Console.ReadLine();

            Console.Write("Введите номер телефона: ");
            client.PhoneNumber = Console.ReadLine();

            Console.Write("Введите свой адрес: ");
            client.Address = Console.ReadLine();

            return client;
        }
    }
}
