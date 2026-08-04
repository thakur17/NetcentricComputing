using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using wesqlite.Model;

namespace wesqlite.Pages.Company
{
    public class SupplierModel : PageModel
    {
        private SupplierContext _db;
        public SupplierModel(SupplierContext db)
        {
            _db = db;
        }

        public IEnumerable<Supplier>? Suppliers { get; set; }
        public void OnGet()
        {
            ViewData["Title"] = "Northwind B2B - Suppliers";
            Suppliers = _db.Suppliers
            .OrderBy(c => c.Country)
            .ThenBy(c => c.CompanyName);

        }

        [BindProperty]
        public Supplier? Supplier { get; set; }
        public IActionResult OnPost()
        {
            if ((Supplier is not null) && ModelState.IsValid)
            {
                _db.Suppliers.Add(Supplier);
                _db.SaveChanges();
                return RedirectToPage("/Company/Supplier");
            }
            else
            {
                return Page(); // return to original page
            }
        }
    }
    }

        
    
