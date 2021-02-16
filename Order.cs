using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop
{
    class Order<T1, T2>
    {
        private T1 number;
        private T2 content;
        
        public Order(T1 number, T2 content)
        {
            this.number = number;
            this.content = content;
        }
        
        public T1 Number
        {
            get { return number; }
        }
        
        public void Print()
        {
            Console.WriteLine("\n\t< Информация о заказе >\n");
            Console.WriteLine("Номер заказа: " + number);
            Console.WriteLine("Дата и время заказа: " + DateTime.Now);
            Console.WriteLine("Содержание заказа: " + content);
            Console.WriteLine("Информация о клиенте: ");
            Console.WriteLine("Информация о доставке: ");
        }
    }
}
