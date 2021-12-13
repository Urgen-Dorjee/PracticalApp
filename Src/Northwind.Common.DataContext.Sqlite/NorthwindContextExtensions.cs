using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Northwind.Common.DataContext.Sqlite
{
	public static class NorthwindContextExtensions
	{
		/// <summary>
		/// Adds NorthwindContext to the specified IServiceCollection. Use the sqlite database provider
		/// </summary>
		/// <param name="services"></param>
		/// <param name="relativePath"> Set to override the default of "..."</param>
		/// <returns>An IServiceCollection that can be used to add more services</returns>

		public static IServiceCollection AddNorthwindContext(this IServiceCollection services,
			string relativePath = "..")
		{
			var databasePath = Path.Combine(relativePath, "Northwind.db");
			services.AddDbContext<NorthwindContext>(options =>
				options.UseSqlite($"Data Source={databasePath}")
					.UseLoggerFactory(new ConsoleLoggerFactory()));
			return services;

		} 
	}
}
