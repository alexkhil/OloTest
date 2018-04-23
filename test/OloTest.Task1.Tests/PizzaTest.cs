using OloTest.Task1.Models;
using Xunit;

namespace OloTest.Task1.Tests
{
    public class PizzaTest
    {
        [Fact]
        public void Pizza_ReflexiveEquality_ReturnsTrue()
        {
            var a = new Pizza(new[] { "cheese" });
            Assert.True(a.Equals(a)); // a == a
        }

        [Fact]
        public void Pizza_SymmetricEquality_ReturnsTrue()
        {
            var a = new Pizza(new[] { "cheese" });
            var b = new Pizza(new[] { "cheese" });

            Assert.True(a.Equals(b)); // a == b
            Assert.True(b.Equals(a)); // b == a
        }

        [Fact]
        public void Pizza_SymmetricEquality_ReturnsFalse()
        {
            var a = new Pizza(new[] { "cheese" });
            var b = new Pizza(new[] { "meat" });

            Assert.False(a.Equals(b)); // a != b
            Assert.False(b.Equals(a)); // b != a
        }

        [Fact]
        public void Pizza_TransitiveEquality_ReturnsTrue()
        {
            var a = new Pizza(new[] { "cheese" });
            var b = new Pizza(new[] { "cheese" });
            var c = new Pizza(new[] { "cheese" });

            Assert.True(a.Equals(b)); // a == b
            Assert.True(b.Equals(c)); // b == c
            Assert.True(a.Equals(c)); // a == c
        }

        [Fact]
        public void Pizza_TransitiveEquality_ReturnsFalse()
        {
            var a = new Pizza(new[] { "cheese" });
            var b = new Pizza(new[] { "meat" });
            var c = new Pizza(new[] { "tomato" });

            Assert.False(a.Equals(b)); // a != b
            Assert.False(b.Equals(c)); // b != c
            Assert.False(a.Equals(c)); // a != c
        }

        [Fact]
        public void Pizzas_WithSameToppingsAndDifferentOrder_ReturnsEqualsTrue()
        {
            var a = new Pizza(new[] { "cheese", "meat" });
            var b = new Pizza(new[] { "meat", "cheese" });

            Assert.True(a.Equals(b));
            Assert.True(b.Equals(a));
        }

        [Fact]
        public void SamePizzas_WhenCalledGetHashCode_ReturnsSameHashCode()
        {
            var a = new Pizza(new[] { "cheese", "meat" });
            var b = new Pizza(new[] { "cheese", "meat" });

            Assert.True(a.Equals(b));
            Assert.True(a.GetHashCode() == b.GetHashCode());
        }
    }
}
