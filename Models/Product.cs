
using System.ComponentModel.DataAnnotations;

namespace LaboratoryWork2.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;

        public decimal Price { get; set; }
    }
}
