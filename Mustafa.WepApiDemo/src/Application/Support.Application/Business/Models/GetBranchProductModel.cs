using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Support.Application.Business.Models
{
    public class GetBranchProductModel
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

        //public List<ProductModel> ProductModel { get; set; }
    }
    //public class ProductModel
    //{
    //    public int ProductId { get; set; }
    //    public string ProductCode { get; set; }
    //    public string ProductName { get; set; }
    //    public int ProductVariantId { get; set; }
    //    public string ProductVariantCode { get; set; }
    //    public int CategoryId { get; set; }
    //    public string CategoryName { get; set; }
    //}
}
