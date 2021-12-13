using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Northwind.Common.EntityModels.Sqlite.Models;

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
