using System;
using System.Collections.Generic;
using System.Linq;

namespace OloTest.Task1.Models
{
    public class Pizza : IEquatable<Pizza>
    {
        private readonly int _hash = 0;

        public string ToppingsKey { get; } = string.Empty;

        public IEnumerable<string> Toppings { get; } = Enumerable.Empty<string>();

        public Pizza(string[] toppings = null)
        {
            if (toppings == null || toppings.Length == 0)
                return;

            Toppings = toppings;
            ToppingsKey = string.Concat(toppings.OrderBy(t => t, StringComparer.OrdinalIgnoreCase));
            _hash = ToppingsKey.GetHashCode();
        }

        public override int GetHashCode()
        {
            return _hash;
        }

        public bool Equals(Pizza other)
        {
            return ToppingsKey == other.ToppingsKey;
        }

        public override bool Equals(object right)
        {
            if (right is null)
                return false;

            if (object.ReferenceEquals(this, right))
                return true;

            return GetType() == right.GetType() && Equals(right as Pizza);
        }

        public override string ToString()
        {
            return $"{string.Join(", ", Toppings)}";
        }
    }
}