using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop
{
    class Client
    {
        public Guid id;
        private string name;
        private string phoneNumber;
        private string address;
        private DateTime birthday;

        public Client(string name, string phoneNumber, string address)
        {
            if (name == "" || name.Contains(" "))
            {
                throw new Exception("Invalid name");
            }

            if (phoneNumber == "" || phoneNumber.Contains(" "))
            {
                throw new Exception("Invalid phoneNumber");
            }

            if (address == "" || address.Contains(" "))
            {
                throw new Exception("Invalid address");
            }

            this.name = name;
            this.phoneNumber = phoneNumber;
            this.address = address;
        }

        public void SetBirthday(DateTime birthday)
        {
            if (birthday > DateTime.Now)
            {
                throw new Exception("Invalid birthday");
            }
            this.birthday = birthday;
        }

        public DateTime GetBirthday()
        {
            return birthday;
        }

        public void Print()
        {
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("PhoneNumber: " + phoneNumber);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Birthday: " + birthday);
        }
    }
}
