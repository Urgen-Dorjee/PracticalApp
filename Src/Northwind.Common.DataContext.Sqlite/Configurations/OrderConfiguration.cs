using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Northwind.Common.EntityModels.Sqlite.Models;

namespace Northwind.Common.DataContext.Sqlite.Configurations
{
	public class OrderConfiguration : IEntityTypeConfiguration<Order>
	{
		public void Configure(EntityTypeBuilder<Order> entity)
		{
			entity.Property(e => e.Freight).HasDefaultValueSql("0");
		}
	}
}
