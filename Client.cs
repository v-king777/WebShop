using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop
{
    class Client
    {
        public Guid Id;
        public string Name;
        public string PhoneNumber;
        public string Address;

        public void Print()
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("PhoneNumber: " + PhoneNumber);
            Console.WriteLine("Address: " + Address);
        }
    }
}
