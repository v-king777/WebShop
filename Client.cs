using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop
{
    class Client
    {
        private Guid id;
        private string name;
        private string phoneNumber;
        private string address;

        public Guid Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value == "")
                {
                    Console.WriteLine("Invalid name");
                }
                else
                {
                    name = value;
                }
            }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                if (value == "" || value.Contains(" "))
                {
                    Console.WriteLine("Invalid phoneNumber");
                }
                else
                {
                    phoneNumber = value;
                }
            }
        }

        public string Address
        {
            get { return address; }
            set
            {
                if (value == "")
                {
                    Console.WriteLine("Invalid address");
                }
                else
                {
                    address = value;
                }
            }
        }

        public static Client NewClient()
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

        public void Print()
        {
            Console.WriteLine("\n\t< Информация о клиенте >\n");
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Номер телефона: " + phoneNumber);
            Console.WriteLine("Адрес: " + address);
        }
    }
}
