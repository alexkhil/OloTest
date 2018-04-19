namespace OloTest.Task2.Models.Product
{
    public class WeightableProduct : ProductBase
    {
        public decimal? Weight { get; set; }

        public override decimal GetTotalPrice() => Weight.HasValue ? Price * Weight.Value : 0;

        public override string ToString() => $"{Name} ${GetTotalPrice()} ({Weight} pounds at ${Price} per pound)";
    }
}