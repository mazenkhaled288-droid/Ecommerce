namespace Ecommerce.Models
{
    public class Brand
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool States { get; set; }
        public string Logo { get; set; } = string.Empty;  
        //public ICollection<product> products{ get; } = new List<product>();
    }
}
