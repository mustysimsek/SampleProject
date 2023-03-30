using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Support.Persistence.Context;
using Support.Domain.Entities;
using Support.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using Support.Application.Services.Models;
using Support.WebApi.Models;
using Support.Application.Business.Abstracts;

namespace Support.WebApi.Controllers
{
    [Route("api/v1/products")]
    public class ProductController : Controller
    {
        private readonly IProductBusiness _productBusiness;

        public ProductController(IProductBusiness productBusiness)
        {
            _productBusiness = productBusiness;
        }

        [HttpGet("{productCode}")]
        public ViewResult GetProductByCode([FromRoute] string productCode)
        {
            #region Old
            //var product = _productBusiness.GetProduct(productCode);
            //var viewModel = new GetProductViewModel()
            //{

            //    CategoryId = product.CategoryId,
            //    Code = product.Code,
            //    CreatedOn = product.CreatedOn,
            //    Id = product.Id,
            //    Name = product.Name
            //};
            //return View(viewModel); 
            #endregion

            return View(_productBusiness.GetProduct(productCode));
        }

        //[HttpGet("GetBranchProduct/{currentCode?}")]
        //[HttpGet("{currentCode}")]
        //public IActionResult GetBranchProduct(int currentCode)
        //{
        //    var list = from p in _dbContext.STProduct
        //               join mp in _dbContext.MTProductCategory on p.FKCategoryId equals mp.PKProductCategoryId
        //               join pv in _dbContext.STProductVariant on p.PKProductId equals pv.FKProductId
        //               join bpr in _dbContext.STBranchProductRelation on p.PKProductId equals bpr.FKProductId
        //               join b in _dbContext.STBranch on bpr.FKBranchId equals b.PKBranchId
        //               where b.CurrentCode == currentCode
        //               select new BranchProductModel
        //               {
        //                   PKBranchId = b.PKBranchId,
        //                   BranchName = b.Name,
        //                   CurrentCode = b.CurrentCode,
        //                   PKProductId = p.PKProductId,
        //                   ProductCode = p.ProductCode,
        //                   ProductName = p.Name,
        //                   PKProductVariantId = pv.PKProductVariantId,
        //                   ProductVariantCode = pv.ProductVariantCode,
        //                   CategoryId = mp.PKProductCategoryId,
        //                   CategoryName = mp.Name
        //               };
        //    //var list = GetListOfProdudctForBranch(currentCode);
        //    return View(list);
        //}


        #region deneme
        //public IActionResult GetProductValues(string? productCode, int currentCode) =>
        //    currentCode == 0 ? GetProduct(productCode) : GetBranchProduct(currentCode);

        //private IActionResult GetProduct(string? productCode)
        //{
        //    List<Capua_Product> listOfProduct = _dbContext.STProduct.Where(a => a.ProductCode == productCode).ToList();

        //    return View(listOfProduct);
        //}

        //private IActionResult GetBranchProduct(int currentCode)
        //{
        //    var list = from p in _dbContext.STProduct
        //               join mp in _dbContext.MTProductCategory on p.FKCategoryId equals mp.PKProductCategoryId
        //               join pv in _dbContext.STProductVariant on p.PKProductId equals pv.FKProductId
        //               join bpr in _dbContext.STBranchProductRelation on p.PKProductId equals bpr.FKProductId
        //               join b in _dbContext.STBranch on bpr.FKBranchId equals b.PKBranchId
        //               where b.CurrentCode == currentCode
        //               select new BranchProductModel
        //               {
        //                   PKBranchId = b.PKBranchId,
        //                   BranchName = b.Name,
        //                   CurrentCode = b.CurrentCode,
        //                   PKProductId = p.PKProductId,
        //                   ProductCode = p.ProductCode,
        //                   ProductName = p.Name,
        //                   PKProductVariantId = pv.PKProductVariantId,
        //                   ProductVariantCode = pv.ProductVariantCode,
        //                   CategoryId = mp.PKProductCategoryId,
        //                   CategoryName = mp.Name
        //               };
        //    //var list = GetListOfProdudctForBranch(currentCode);
        //    return View(list);
        //} 
        #endregion
    }

}

