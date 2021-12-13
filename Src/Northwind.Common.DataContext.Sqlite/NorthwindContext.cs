using Microsoft.EntityFrameworkCore;
using Northwind.Common.EntityModels.Sqlite.Models;

namespace Northwind.Common.DataContext.Sqlite
{
	public partial class NorthwindContext : DbContext
	{
		public NorthwindContext()
		{
		}

		public NorthwindContext(DbContextOptions<NorthwindContext> options)
			: base(options)
		{
		}

		public virtual DbSet<Category> Categories { get; set; } = null!;
		public virtual DbSet<Customer> Customers { get; set; } = null!;
		public virtual DbSet<Employee> Employees { get; set; } = null!;
		public virtual DbSet<EmployeeTerritory> EmployeeTerritories { get; set; } = null!;
		public virtual DbSet<Order> Orders { get; set; } = null!;
		public virtual DbSet<OrderDetail> OrderDetails { get; set; } = null!;
		public virtual DbSet<Product> Products { get; set; } = null!;
		public virtual DbSet<Shipper> Shippers { get; set; } = null!;
		public virtual DbSet<Supplier> Suppliers { get; set; } = null!;
		public virtual DbSet<Territory> Territories { get; set; } = null!;

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlite("Filename=../Northwind.db");
			}
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfigurationsFromAssembly(typeof(NorthwindContext).Assembly);
			OnModelCreatingPartial(builder);
		}

		partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
	}
}
