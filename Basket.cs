using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop
{
    class Basket
    {
        private Product[] products;
        private object[] content = new object[byte.MaxValue];

        public Basket(Product[] products)
        {
            this.products = products;
        }

        public void ProductAdd(int indexOfProduct)
        {
            content[0] = products[indexOfProduct];
        }
    }
}
