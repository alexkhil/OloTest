using OloTest.Task1.Models;
using System.Collections.Generic;
using System.Linq;

namespace OloTest.Task1.Repositories
{
    /// <summary>
    /// Interface for Pizza Repository
    /// </summary>
    public interface IPizzaRepository
    {
        IOrderedEnumerable<KeyValuePair<Pizza, int>> GetPopularPizzas();
    }
}