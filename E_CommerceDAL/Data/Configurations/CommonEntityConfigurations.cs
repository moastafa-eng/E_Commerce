using E_CommerceDAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_CommerceDAL.Data.Configurations
{
    // Generic Class
    public class CommonEntityConfigurations<T> : IEntityTypeConfiguration<T> where T : CommonEntity
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            // Name Configurations
            builder.Property(x => x.Name)
                .HasColumnType("varchar")
                .HasMaxLength(50);

            // Description Configurations
            builder.Property(x => x.Description)
                .HasColumnType("varchar")
                .HasMaxLength(100);
        }
    }
}
