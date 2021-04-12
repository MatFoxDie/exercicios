using Enum.Entities;
using Enum.Entities.Enums;
using System;


namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PedingPayment
            };
            Console.WriteLine(order);

            string txt = OrderStatus.PedingPayment.ToString();

            Console.WriteLine(txt);

            
            Console.ReadKey();
        }
    }
}
