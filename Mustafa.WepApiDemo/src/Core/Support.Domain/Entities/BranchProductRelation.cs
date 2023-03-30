using System.ComponentModel.DataAnnotations;

namespace Support.Domain.Entities
{
    public class BranchProductRelation
    {
        [Key]
        public int PKBranchProductRelationId { get; set; }
        public int FKBranchId { get; set; }
        public Branch Branch { get; set; }
        public int FKProductId { get; set; }
        public Product Product { get; set; }
    }
}
