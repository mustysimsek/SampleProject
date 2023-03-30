using System.ComponentModel.DataAnnotations;

namespace Support.Domain.Entities
{
    public class Branch
    {
        [Key]
        public int PKBranchId { get; set; }
        public string Name { get; set; }
        public int CurrentCode { get; set; }
        public int CreatedOn { get; set; }
        public int FKStoreId { get; set; }
        public List<BranchProductRelation> BranchProductRelations { get; set; }
    }
}
