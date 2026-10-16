using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.DataAccess.Entity_Configrations
{
    public class ProductColorEntityTypeConfigration : IEntityTypeConfiguration<ProductColor>
    {
        public void Configure(EntityTypeBuilder<ProductColor> builder)
        {
            builder.Property(e => e.Color).IsRequired().HasMaxLength(9);
        }
    }
}
