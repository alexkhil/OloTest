using OloTest.Task2.Models;
using OloTest.Task2.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OloTest.Task2.SummaryBuilder
{
    public class OrderSummaryBuilder : SummaryBuilderBase
    {
        private readonly Order _order;
        
        public OrderSummaryBuilder(Order order)
        {
            _order = order ?? throw new ArgumentNullException(nameof(order));
        }

        public override string Build()
        {
            if (StringBuilder.Length == 0)
            {
                BuildHeader(_order.Customer.FirstName, _order.Customer.LastName);
                StringBuilder.AppendLine();

                BuildRows(_order.Products);
                StringBuilder.AppendLine();

                BuildTotalPrice(_order.Products);
            }

            return StringBuilder.ToString();
        }

        private void BuildHeader(string firstName, string lastName)
        {
            StringBuilder.AppendLine($"ORDER SUMMARY FOR {firstName} {lastName}:");
        }

        private void BuildRows(IEnumerable<ProductBase> products)
        {
            foreach (var orderProduct in products)
            {
                StringBuilder.AppendLine(orderProduct.ToString());
            }
        }

        private void BuildTotalPrice(IEnumerable<ProductBase> products)
        {
            var totalPrice = products.Sum(product => product.GetTotalPrice());
            StringBuilder.AppendLine($"Total Price: ${totalPrice}");
        }
    }
}