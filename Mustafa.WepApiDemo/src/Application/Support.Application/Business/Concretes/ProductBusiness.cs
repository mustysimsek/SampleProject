using Support.Application.Business.Abstracts;
using Support.Application.Services.Abstracts;
using Support.Application.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Support.Application.Business.Concretes
{
    public class ProductBusiness : IProductBusiness
    {
        private readonly IProductService _productService;

        public ProductBusiness(IProductService productService)
        {
            _productService = productService;
        }

        public GetProductModel GetProduct(string productCode)
        {
            if (productCode == null) return null;
            var product = _productService.GetProduct(productCode);
            return new GetProductModel()
            {

                CategoryId = product.FKCategoryId,
                Code = product.ProductCode,
                CreatedOn = product.CreatedOn,
                Id = product.PKProductId,
                Name = product.Name
            }; 
        }
    }
}
