![OloLogo][OloLogo]

## Table of Content

- [Task 1: Finding Popular Build-Your-Own Pizzas](#task-1-finding-popular-build-your-own-pizzas)
  - [Description](#description)
  - [Explanation](#explanation)
- [Task 2: Do the code refactoring](#task-2-do-the-code-refactoring)
  - [Description](#description-1)
  - [Explanation](#explanation-1)
- [License](#license)

### Task 1: Finding Popular Build-Your-Own Pizzas

#### Description
A pizza chain wants to know which topping combinations are most popular for Build Your Own pizzas.

Given the sample of orders at json, write an application to output the top 20 most frequently ordered pizza configurations, listing the toppings for each along with the number of times that pizza configuration has been ordered.

#### Explanation
Processing...

### Task 2: Do the code refactoring

#### Description
Refactor the code listed below:

```csharp
using System;
using System.Collections.Generic;

namespace Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Tuple<string, List<Product>>("John Doe",
                new List<Product>
                {
                    new Product
                    {
                        ProductName = "Pulled Pork",
                        Price = 6.99m,
                        Weight = 0.5m,
                        PricingMethod = "PerPound",
                    },
                    new Product
                    {
                        ProductName = "Coke",
                        Price = 3m,
                        Quantity = 2,
                        PricingMethod = "PerItem"
                    }
                }
            );

            var price = 0m;
            var orderSummary = "ORDER SUMMARY FOR " + order.Item1 + ": \r\n";

            foreach (var orderProduct in order.Item2)
            {
                var productPrice = 0m;
                orderSummary += orderProduct.ProductName;

                if (orderProduct.PricingMethod == "PerPound")
                {
                    productPrice = (orderProduct.Weight.Value * orderProduct.Price);
                    price += productPrice;
                    orderSummary += (" $" + productPrice + " (" + orderProduct.Weight + " pounds at $" + orderProduct.Price + " per pound)");
                }
                else // Per item
                {
                    productPrice = (orderProduct.Quantity.Value * orderProduct.Price);
                    price += productPrice;
                    orderSummary += (" $" + productPrice + " (" + orderProduct.Quantity + " items at $" + orderProduct.Price + " each)");
                }

                orderSummary += "\r\n";
            }

            Console.WriteLine(orderSummary);
            Console.WriteLine("Total Price: $" + price);

            Console.ReadKey();
        }
    }

    public class Product
    {
        public string ProductName;
        public decimal Price;
        public decimal? Weight;
        public int? Quantity;
        public string PricingMethod;
    }
}
```

#### Explanation

Processing...

## License

This project is licensed under the MIT License - see the [LICENSE.md][LICENSE] file for details.

[OloLogo]: https://image.ibb.co/c5A1in/OLO.png
[LICENSE]: https://github.com/alexkhil/OloTest/blob/master/LICENSE