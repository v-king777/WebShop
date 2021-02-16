using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop
{
    class Basket
    {
        private object[] content = new object[byte.MaxValue];
        private Product[] products;
        
        public Basket(Product[] products)
        {
            this.products = products;
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
            
            double summPrice = 0;
            
            foreach (Product product in content)
            {
                if (product != null)
                {
                    Console.WriteLine("{0}. Цена {1} руб.", product.Name, product.Price);
                    summPrice = summPrice + product.Price;
                }
            }
            
            Console.WriteLine("\nСумма к оплате: {0} руб.", summPrice);
        }
    }
}
