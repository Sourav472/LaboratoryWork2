
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LaboratoryWork2.Data;
using LaboratoryWork2.Models;

namespace LaboratoryWork2.Pages.ProductPages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get; set; } = new List<Product>();

        public async Task OnGetAsync()
        {
            Product = await _context.Products
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
