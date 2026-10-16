namespace Ecommerce.ViewModel
{
    public class productItemWithRelatedVM
    {
        public Product product { get; set; }
        public IEnumerable<Product> RelatedProducts { get; set; }
    }
}
