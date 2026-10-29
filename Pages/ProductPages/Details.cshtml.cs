
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LaboratoryWork2.Models;
using LaboratoryWork2.Data;

namespace LaboratoryWork2.Pages.ProductPages;

public class DetailsModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public DetailsModel(ApplicationDbContext context)
    {
        _context = context;
    }

    public Product Product { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var product = await _context.Products
            .AsNoTracking()
            .FirstOrDefaultAsync(m => m.ProductID == id);

        if (product is null)
        {
            return NotFound();
        }

        Product = product;

        return Page();
    }
}
