using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Support.Persistence.Context;
using Support.Domain.Entities;
using Support.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using Support.WebApi.Models;
using Support.Application.Business.Abstracts;
using Mapster;

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
        //[HttpGet]
        public ViewResult GetProductByCodePage()
        {
            return View();

        }
        [HttpGet("{productCode}")]
        public ViewResult GetProductByCode([FromRoute] string productCode)
        {
            var product = _productBusiness.GetProduct(productCode);
            #region Manuel-Mapping
            //var viewModel = new GetProductViewModel()
            //{
            //    CategoryId = product.CategoryId,
            //    Code = product.Code,
            //    CreatedOn = product.CreatedOn,
            //    Id = product.Id,
            //    Name = product.Name
            //}; 
            #endregion
            return View(product.Adapt<GetProductViewModel>());
        }
    }
}

