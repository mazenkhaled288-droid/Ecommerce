namespace Ecommerce.Models
{
    public class ProductSubImg
    {
        public int Id { get; set; }
        public string subImg { get; set; }=string .Empty;
        public int productId { get; set; }
        public Product product { get; set; }
    }
}
