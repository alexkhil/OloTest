using OloTest.Task2.Models;

namespace OloTest.Task2.Repositories.OrderRepository
{
    public interface IOrderRepository
    {
        Order GetOrderByCustomer(string firstName, string lastName);
    }
}