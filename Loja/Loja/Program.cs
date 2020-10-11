using System;
using Loja.Entities;

namespace Loja
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.Pendingpayment
            };

            Console.WriteLine(order);
        }
    }
}
