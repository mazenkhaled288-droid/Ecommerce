namespace Ecommerce.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool States { get; set; }
        public string? Description{ get; set; }
        //public ICollection<product> products{ get; } = new List<product>();
    }
}
