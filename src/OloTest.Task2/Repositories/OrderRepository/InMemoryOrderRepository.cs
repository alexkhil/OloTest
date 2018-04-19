using OloTest.Task2.Models;
using OloTest.Task2.Models.Product;
using System.Collections.Generic;
using System.Linq;

namespace OloTest.Task2.Repositories.OrderRepository
{
    public class InMemoryOrderRepository : IOrderRepository
    {
        private readonly ICollection<Order> _orders;

        public InMemoryOrderRepository()
        {
            _orders = new List<Order>
            {
                new Order
                {
                    Customer = new Customer { FirstName = "John", LastName = "Doe" },
                    Products = new List<ProductBase>
                    {
                        new WeightableProduct
                        {
                            Name = "Pulled Pork",
                            Price = 6.99m,
                            Weight = 0.5m
                        },
                        new QuantitableProduct
                        {
                            Name = "Coke",
                            Price = 3m,
                            Quantity = 2
                        }
                    }
                }
            };
        }

        public Order GetOrderByCustomer(string firstName, string lastName)
        {
            return _orders.FirstOrDefault(order => order.Customer.FirstName == firstName
                                                || order.Customer.LastName == lastName);
        }
    }
}