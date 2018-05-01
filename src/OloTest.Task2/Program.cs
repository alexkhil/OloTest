using OloTest.Task2.Repositories.OrderRepository;
using OloTest.Task2.SummaryBuilder;
using System;

namespace OloTest.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderRepository = new InMemoryOrderRepository();
            var order = orderRepository.GetOrderByCustomer("John", "Doe");
            if (order != null)
            {
                var orderSummaryBuilder = new OrderSummaryBuilder(order);
                Console.WriteLine(orderSummaryBuilder.Build());
            }
            else
            {
                Console.WriteLine("Order not found");
            }

            Console.ReadKey();
        }
    }
}