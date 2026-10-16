using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.DataAccess.Entity_Configrations
{
    public class ProductEntityTypeConfigration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(e => e.Name).IsRequired().HasMaxLength(100);
            builder.Property(e => e.Description).IsRequired(false).HasMaxLength(500);
            builder.Property(e => e.MainImg).IsRequired().HasMaxLength(500);
            builder.Property(e => e.price).HasPrecision(10,2);
            builder.Property(e => e.Discount).HasPrecision(3,1);
        }
    }
}
