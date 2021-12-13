using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Northwind.Common.EntityModels.Sqlite.Models;

namespace Northwind.Common.DataContext.Sqlite.Configurations
{
	public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
	{
		public void Configure(EntityTypeBuilder<OrderDetail> entity)
		{
			entity.HasKey(e => new { e.OrderId, e.ProductId });

			entity.HasOne(d => d.Order)
				.WithMany(p => p.OrderDetails)
				.HasForeignKey(d => d.OrderId)
				.OnDelete(DeleteBehavior.ClientSetNull);

			entity.HasOne(d => d.Product)
				.WithMany(p => p.OrderDetails)
				.HasForeignKey(d => d.ProductId)
				.OnDelete(DeleteBehavior.ClientSetNull);
		}
	}
}
