using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop
{
    class Order<T>
    {
        private T number;
        
        public Order(T number)
        {
            this.number = number;
        }
        
        public T Number
        {
            get { return number; }
        }
        
        public void Print()
        {
            Console.WriteLine("\n\t< Информация о заказе >\n");
            Console.WriteLine("Номер заказа: " + number);
            Console.WriteLine("Дата и время заказа: " + DateTime.Now);
            Console.WriteLine("Содержание заказа: ");
            Console.WriteLine("Информация о клиенте: ");
            Console.WriteLine("Информация о доставке: ");
        }
    }
}