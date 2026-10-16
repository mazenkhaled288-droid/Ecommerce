namespace Ecommerce.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool States { get; set; }
        public string? Description { get; set; }
        public string MainImg { get; set; } = string.Empty;
        public decimal price { get; set; }
        public decimal Discount{ get; set; }
        public int Quantity{ get; set; }
        public double Rate{ get; set; }
        public int Traffic{ get; set; }
        public int CategoryId{ get; set; }
        public int BrandId{ get; set; }

        public Category Category { get; set; } = null!;
        public Brand Brand { get; set; } = null!;
    }
}
