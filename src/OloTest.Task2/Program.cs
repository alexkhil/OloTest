using OloTest.Task2.Repositories.OrderRepository;
using System;

namespace OloTest.Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var orderRepository = new InMemoryOrderRepository();
            var order = orderRepository.GetOrderByCustomer("John", "Doe");
            if (order != null)
                Console.Write(order.Summary());

            Console.ReadKey();
        }
    }
}