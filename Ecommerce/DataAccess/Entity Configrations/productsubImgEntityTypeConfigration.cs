using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.DataAccess.Entity_Configrations
{
    public class productsubImgEntityTypeConfigration : IEntityTypeConfiguration<ProductSubImg>
    {
        public void Configure(EntityTypeBuilder<ProductSubImg> builder)
        {
            builder.Property(e => e.subImg).IsRequired().HasMaxLength(500);
        }
    }
}
