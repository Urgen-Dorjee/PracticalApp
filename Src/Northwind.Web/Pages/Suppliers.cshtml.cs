using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Northwind.Common.DataContext.Sqlite;
using Northwind.Common.EntityModels.Sqlite.Models;

namespace Northwind.Web.Pages
{
    public class SuppliersModel : PageModel
    {
        public IEnumerable<Supplier> Suppliers { get; set; }
        public void OnGet()
        {
            ViewData["Title"] = "NorthWind B2B - Suppliers";

            Suppliers = _dbContext.Suppliers;
        }
        private NorthwindContext _dbContext;

        public SuppliersModel(NorthwindContext dbContext)
        {
            _dbContext = dbContext;
        }

        [BindProperty]
        public Supplier? Supplier { get; set; }

        public IActionResult OnPost()
        {
            if (Supplier is not null && ModelState.IsValid)
            {
                _dbContext.Suppliers.Add(Supplier);
                _dbContext.SaveChanges();
                return RedirectToPage("/suppliers");
            }
            else
            {
                return Page();
            }
        }
    }
}
