using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Northwind.Common.DataContext.Sqlite.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> entity)
        {
            entity.Property(p => p.UnitPrice)
                .HasConversion<double>();
        }
    }
}
