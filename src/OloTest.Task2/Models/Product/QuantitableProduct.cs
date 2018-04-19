namespace OloTest.Task2.Models.Product
{
    public class QuantitableProduct : ProductBase
    {
        public decimal? Quantity { get; set; }

        public override decimal GetTotalPrice() => Quantity.HasValue ? Quantity.Value * Price : 0;

        public override string ToString() => $"{Name} ${GetTotalPrice()} ({Quantity} items at ${Price} each)";
    }
}