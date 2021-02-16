using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop
{
    class Order
    {
        private string number;
        private object[] content;
        private double summ;
        private string clientName;
        private string clientPhone;
        private string deliveryAddress;

        public Order(string number, object[] content, double summ, string clientName, string clientPhone, string deliveryAddress)
        {
            this.number = number;
            this.content = content;
            this.summ = summ;
            this.clientName = clientName;
            this.clientPhone = clientPhone;
            this.deliveryAddress = deliveryAddress;
        }

        public void Print()
        {
            Console.WriteLine("\n\t< Информация о заказе >\n");
            Console.WriteLine("Номер заказа: " + number);
            Console.WriteLine("Дата и время заказа: " + DateTime.Now);

            Console.WriteLine("\nСписок товаров:\n");

            foreach (Product product in content)
            {
                if (product != null)
                {
                    Console.WriteLine("{0}. Цена {1} руб. {2}", product.Name, product.Price, product.Description);
                }
            }

            Console.WriteLine("\nИтого к оплате: {0} руб.", summ);
            Console.WriteLine("\nПокупатель: {0}, тел. {1}", clientName, clientPhone);
            Console.WriteLine("\nДоставка по адресу: " + deliveryAddress);
        }
    }
}
