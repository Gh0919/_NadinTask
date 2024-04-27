using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NadinTask.Domain.Entities;

namespace NadinTask.Infrastructure.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(256);
            builder.Property(x => x.ManufactureEmail).HasMaxLength(256);
            builder.Property(x => x.ManufacturePhone).HasMaxLength(16);

        }
    }
}
