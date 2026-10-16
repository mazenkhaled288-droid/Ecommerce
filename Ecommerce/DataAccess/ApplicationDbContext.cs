using Ecommerce.DataAccess.Entity_Configrations;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product>products { get; set; }
        public DbSet<Category>Categories { get; set; }
        public DbSet<Brand>Brands { get; set; }
        public DbSet<ProductSubImg>ProductSubImgs { get; set; }
        public DbSet<ProductColor>productColors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.\\MSSQLSERVER01;Initial Catalog=Ecommerce;Integrated Security=True;Encrypt=True;Trust Server Certificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BrandEntityTypeConfigration).Assembly);
        }
    }
    
}
