namespace Ecommerce.Models
{
    public class ProductColor
    {
        public int Id { get; set; }
        public string Color { get; set; } = string.Empty;
        public int productId { get; set; }
        public Product product { get; set; }
    }
}
