/*
* Finding Popular Build-Your-Own Pizzas
*
* A pizza chain wants to know which topping combinations are most popular for Build Your Own pizzas.
* Given the sample of orders at json, write an application to output the top 20 most frequently ordered pizza configurations,
* listing the toppings for each along with the number of times that pizza configuration has been ordered.
*/

using ConsoleTables;
using OloTest.Task1.ConsoleTableBuilder;
using OloTest.Task1.Repositories;
using System.Linq;

namespace OloTest.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizzaRepository = new PizzaRepository();
            var topPizzas = pizzaRepository.GetPopularPizzas().Take(20).ToList();

            var resultBuilder = new TopPizzaConsoleTableBuilder(topPizzas);
            var consoleTable = resultBuilder.Build();
            consoleTable.Write(Format.MarkDown);
        }
    }
}
