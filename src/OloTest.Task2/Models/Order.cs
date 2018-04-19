using OloTest.Task2.Models.Product;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OloTest.Task2.Models
{
    public class Order
    {
        public Customer Customer { get; set; }
        public ICollection<ProductBase> Products { get; set; } = new List<ProductBase>();

        public string Summary()
        {
            var stringBuilder = new StringBuilder($"ORDER SUMMARY FOR {Customer.FirstName} {Customer.LastName}:");
            stringBuilder.AppendLine();

            foreach (var orderProduct in Products)
            {
                stringBuilder.AppendLine(orderProduct.ToString());
            }
            stringBuilder.AppendLine();

            var totalPrice = Products.Sum(product => product.GetTotalPrice());
            stringBuilder.AppendLine($"Total Price: ${totalPrice}");

            return stringBuilder.ToString();
        }
    }
}