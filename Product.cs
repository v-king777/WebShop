using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop
{
    class Product
    {
        private string name;
        private int price;
        private string description;

        public Product(string name, int price, string description)
        {
            if (name == "" || name.Contains(" "))
            {
                Console.WriteLine("Invalid name");
            }
            else if (price <= 0)
            {
                Console.WriteLine("Invalid price");
            }
            else if (description == "")
            {
                Console.WriteLine("No description");
            }
            else
            {
                this.name = name;
                this.price = price;
                this.description = description;
            }
        }

        public string Description
        {
            get { return description; }
        }

        public int Price
        {
            get { return price; }
        }

        public string Name
        {
            get { return name; }
        }

    }
}
