using OloTest.Task1.Models;
using System.Collections.Generic;

namespace OloTest.Task1.ConsoleTableBuilder
{
    /// <summary>
    /// Console Table builder for top pizzas
    /// </summary>
    public class TopPizzaConsoleTableBuilder : ConsoleTableBuilderBase
    {
        private readonly IEnumerable<KeyValuePair<Pizza, int>> _topPizzas;

        public TopPizzaConsoleTableBuilder(IEnumerable<KeyValuePair<Pizza, int>> topPizzas)
        {
            _topPizzas = topPizzas;
        }

        protected override void BuildHeader()
        {
            ConsoleTable.AddColumn(new[] {"#", "Pizza", "Amount"});
        }

        protected override void BuildRows()
        {
            var pizzaPosition = 1;
            foreach (var pizzaGroup in _topPizzas)
            {
                ConsoleTable.AddRow(pizzaPosition, pizzaGroup.Key, pizzaGroup.Value);
                pizzaPosition++;
            }
        }
    }
}