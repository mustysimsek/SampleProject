using Support.Application.Services.Abstracts;
using Support.Domain.Entities;
using Support.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Support.Application.Services.Concretes
{
    public class ProductService : IProductService
    {
        private readonly BevBreadDBContext _dbContext;
        public ProductService(BevBreadDBContext dbContex)
        {
            _dbContext = dbContex;
        }
        public Product GetProduct(string productCode)
        {
            #region Ahmet ile baktığımız
            //Product product = _dbContext.STProduct.FirstOrDefault(a => a.ProductCode == productCode);
            //if (product == null) return null;
            //return new GetProductModel()
            //{

            //    CategoryId = product.FKCategoryId,
            //    Code = product.ProductCode,
            //    CreatedOn = product.CreatedOn,
            //    Id = product.PKProductId,
            //    Name = product.Name
            //}; 
            #endregion

            var product = _dbContext.STProduct.FirstOrDefault(a => a.ProductCode == productCode);
            if (product == null) return null;
            return product;

        }
        //Business a alacaksın
        //
        //public string GetProductName(string productCode)
        //{
        //    Product product = _dbContext.STProduct.FirstOrDefault(a => a.ProductCode == productCode);
        //    if (product == null) return null;
        //    return product.Name;
        //}
    }
}
