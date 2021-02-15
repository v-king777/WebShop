using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop
{
    class Catalog
    {
        private Product[] products = GetCatalog();

        public Product[] Products
        {
            get { return products; }
        }

        private static Product[] GetCatalog()
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Пылесос", 15000, "Очень мощный пылесос"));
            list.Add(new Product("Холодильник", 30000, "Очень большой холодильник"));
            list.Add(new Product("Диван", 40000, "Очень мягкий диван"));
            list.Add(new Product("Телевизор", 50000, "Очень крутой телевизор"));
            list.Add(new Product("Синтезатор", 100000, ""));
            list.Add(new Product("Говнакусок", 1, "Самый обыкновенный кусок говна"));

            Product[] catalog = list.ToArray();

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
