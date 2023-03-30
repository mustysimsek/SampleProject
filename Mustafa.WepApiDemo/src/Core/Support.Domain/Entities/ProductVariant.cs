using System;
using System.ComponentModel.DataAnnotations;

namespace Support.Domain.Entities
{
    public class ProductVariant
    {
        [Key]
        public int PKProductVariantId { get; set; }

        public string ProductVariantCode { get; set; }
        public int CreatedOn { get; set; }
        public int FKProductId { get; set; }
        public Product Product { get; set; }
    }
}
