
using Microsoft.EntityFrameworkCore;
using LaboratoryWork2.Models;

namespace LaboratoryWork2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
