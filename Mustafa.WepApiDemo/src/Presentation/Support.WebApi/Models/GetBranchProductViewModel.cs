namespace Support.WebApi.Models
{
    public class GetBranchProductViewModel
    {
        public int PKBranchId { get; set; }
        public string BranchName { get; set; }
        public int CurrentCode { get; set; }
        public int PKProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int PKProductVariantId { get; set; }
        public string ProductVariantCode { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
