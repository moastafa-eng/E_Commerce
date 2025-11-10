using E_CommerceDAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_CommerceDAL.Data.Configurations
{
    internal class ProductConfigurations : CommonEntityConfigurations<Product>, IEntityTypeConfiguration<Product>
    {
        public new void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.Price)
                .HasPrecision(10, 2); // Decimal Precision (99999999.99)

            // configure relation ship
            builder.HasOne(x => x.Category)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.CategoryId);
        }
    }
}
