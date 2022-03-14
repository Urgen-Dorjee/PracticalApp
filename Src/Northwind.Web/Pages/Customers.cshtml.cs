using Microsoft.AspNetCore.Mvc.RazorPages;
using Northwind.Common.DataContext.Sqlite;
using Northwind.Common.EntityModels.Sqlite.Models;

namespace Northwind.Web.Pages
{
    public class CustomersModel : PageModel
    {
        private readonly NorthwindContext _dbContext;
        public ILookup<string?, Customer>? CustomersByCountry;

        public void OnGet()
        {
            CustomersByCountry = _dbContext.Customers
                .ToLookup(c => c.Country);
        }


        public CustomersModel(NorthwindContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
