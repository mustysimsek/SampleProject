using System.ComponentModel.DataAnnotations;

namespace Support.Domain.Entities
{
    public class ProductCategory
    {
        [Key]
        public int PKProductCategoryId { get; set; }
        public string Name { get; set; }
        public Product Product { get; set; }
    }
}
