using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop
{
    class Basket
    {
        private object[] content = new object[byte.MaxValue];
        private Product[] products;
        private double priceSumm;

        public Basket(Product[] products)
        {
            this.products = products;
        }

        public Product[] Products
        {
            get { return products; }
        }

        public object[] Content
        {
            get { return content; }
        }

        public double PriceSumm
        {
            get { return priceSumm; }
        }

        public void ProductAdd(int indexOfProduct)
        {
            for (int i = 0; i < content.Length; i++)
            {
                if (content[i] == null)
                {
                    content[i] = products[indexOfProduct];
                    break;
                }
            }
        }

        public void ViewBasket()
        {
            Console.WriteLine("\n\t< Корзина >\n");

            priceSumm = 0;

            foreach (Product product in content)
            {
                if (product != null)
                {
                    Console.WriteLine("{0}. Цена {1} руб.", product.Name, product.Price);
                    priceSumm += product.Price;
                }
            }

            Console.WriteLine("\nТоваров на сумму: {0} руб.", priceSumm);
        }
    }
}
