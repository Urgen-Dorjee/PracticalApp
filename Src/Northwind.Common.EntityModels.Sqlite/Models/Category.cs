namespace Northwind.Common.EntityModels.Sqlite.Models
{
	[Index(nameof(CategoryName), Name = "CategoryName")]
	public partial class Category
	{
		public Category()
		{
			Products = new HashSet<Product>();
		}

		[Key]
		public int CategoryId { get; set; }

		[Required]
		[Column(TypeName = "nvarchar (15)")]
		[StringLength(15)]
		public string CategoryName { get; set; } = null!;
		[Column(TypeName = "ntext")]
		public string? Description { get; set; }
		[Column(TypeName = "image")]
		public byte[]? Picture { get; set; }

		[InverseProperty(nameof(Product.Category))]
		public virtual ICollection<Product> Products { get; set; }
	}
}
