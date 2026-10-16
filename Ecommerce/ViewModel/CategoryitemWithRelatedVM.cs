namespace Ecommerce.ViewModel
{
    public class CategoryitemWithRelatedVM
    {
        public IEnumerable<Category> Categories { get; set; } = new List<Category>();
        public string Name { get; set; } = string.Empty;
        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }
    }
}
