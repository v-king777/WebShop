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
                if (value == "" || value.Contains(" "))
                {
                    throw new Exception("Invalid name");
                }
                name = value;
            }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                if (value == "" || value.Contains(" "))
                {
                    throw new Exception("Invalid phoneNumber");
                }
                phoneNumber = value;
            }
        }

        public string Address
        {
            get { return address; }
            set
            {
                if (value == "" || value.Contains(" "))
                {
                    throw new Exception("Invalid address");
                }
                address = value;
            }
        }

        public void Print()
        {
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("PhoneNumber: " + phoneNumber);
            Console.WriteLine("Address: " + address);
        }
    }
}
