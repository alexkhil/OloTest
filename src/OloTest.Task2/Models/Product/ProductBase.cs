namespace OloTest.Task2.Models.Product
{
    public abstract class ProductBase
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public abstract decimal GetTotalPrice();
    }
}