using System;
using enum_01.Entities;
using enum_01.Entities.Enums;

namespace enum_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order.ToString());

            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            System.Console.WriteLine(os);
        }
    }
}
