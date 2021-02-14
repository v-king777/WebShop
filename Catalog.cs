using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop
{
    class Catalog
    {
        public static object[] GetCatalog()
        {
            List<Product> products = new List<Product>();

            products.Add(new Product("Пылесос", 15000, "Очень мощный пылесос"));
            products.Add(new Product("Холодильник", 30000, "Очень большой холодильник"));
            products.Add(new Product("Диван", 40000, "Очень мягкий диван"));
            products.Add(new Product("Телевизор", 50000, "Очень крутой телевизор"));
            products.Add(new Product("Синтезатор", 100000, ""));
            products.Add(new Product("Говнакусок", 1, "Самый обыкновенный кусок говна"));

            object[] catalog = products.ToArray();
            
            return catalog;
        }

        public static void ViewCatalog()
        {
            Console.WriteLine("\n\t< Каталог товаров >\n");

            foreach (Product product in GetCatalog())
            {
                Console.WriteLine("{0}. Цена {1} руб. {2}", product.Name, product.Price, product.Description);
            }
        }
    }
}
