using Support.Application.Business.Abstracts;
using Support.Application.Business.Models;
using Support.Application.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Support.Application.Business.Concretes
{
    public class BranchBusiness : IBranchBusiness
    {
        private readonly IBranchService _branchService;

        public BranchBusiness(IBranchService branchService)
        {
            _branchService = branchService;
        }
        public async Task<List<GetBranchProductModel>> GetBranchProducts(int currentCode)
        {
            var products = await _branchService.GetBranchProduct(currentCode);
            #region Modelde gönderilmek istenene göre (Örn;ProductId ProdutModelden)
            //var group = products.GroupBy(s => new { s.PKBranchId, s.BranchName, s.CurrentCode }).Select(x => new GetBranchProductModel()
            //{
            //    BranchId = x.Key.PKBranchId,
            //    BranchName = x.Key.BranchName,
            //    CurrentCode = x.Key.CurrentCode,
            //    ProductModel = x.Select(s => new ProductModel
            //    {
            //        CategoryId = s.CategoryId,
            //        CategoryName = s.CategoryName,
            //        ProductCode = s.ProductCode,
            //        ProductId = s.PKProductId,
            //        ProductVariantId = s.PKProductVariantId,
            //        ProductName = s.ProductName,
            //        ProductVariantCode = s.ProductVariantCode
            //    }).ToList()
            //}).ToList(); 
            #endregion

            #region Old
            return products.Select(product => new GetBranchProductModel()
            {
                PKBranchId = product.PKBranchId,
                BranchName = product.BranchName,
                CategoryId = product.CategoryId,
                CategoryName = product.CategoryName,
                CurrentCode = product.CurrentCode,
                PKProductId = product.PKProductId,
                PKProductVariantId = product.PKProductVariantId,
                ProductCode = product.ProductCode,
                ProductName = product.ProductName,
                ProductVariantCode = product.ProductVariantCode
            }).ToList();
            #endregion
            //return group;

        }
    }
}
