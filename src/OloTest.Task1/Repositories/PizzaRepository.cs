using Newtonsoft.Json;
using OloTest.Task1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OloTest.Task1.Repositories
{
    public class PizzaRepository : IPizzaRepository
    {
        private readonly IEnumerable<Pizza> _pizzas;

        public PizzaRepository(string path = "pizzas.json")
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException(nameof(path));

            var fileStream = new FileStream(path, FileMode.Open);
            using (var streamReader = new StreamReader(fileStream))
            {
                _pizzas = JsonConvert.DeserializeObject<IEnumerable<Pizza>>(streamReader.ReadToEnd());
            }
        }

        public IOrderedEnumerable<KeyValuePair<Pizza, int>> GetPopularPizzas()
        {
            var dictionary = new Dictionary<Pizza, int>();
            foreach (var pizza in _pizzas)
            {
                if (dictionary.ContainsKey(pizza))
                    dictionary[pizza]++;
                else
                    dictionary.Add(pizza, 1);
            }
            return dictionary.OrderByDescending(gr => gr.Value);
        }
    }
}