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
                throw new Exception("Invalid name");
            }
            
            if (price <= 0)
            {
                throw new Exception("Invalid price");
            }
            
            if (description == "")
            {
                this.description = "No description";
            }
            else
            {
                this.description = description;
            }
            this.name = name;
            this.price = price;
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
