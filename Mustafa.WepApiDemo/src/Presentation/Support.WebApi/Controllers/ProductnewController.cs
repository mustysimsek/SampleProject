using GemBox.Spreadsheet;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Support.Persistence.Context;
using Support.Domain.Entities;
using Support.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using ThirdParty.Json.LitJson;

namespace Support.WebApi.Controllers
{
    [Route("api/v1/productnews")]
    public class ProductnewController : Controller
    {
        private readonly DataContext _context;
        public ProductnewController(DataContext context)
        {
            _context = context;
        }
        //[HttpGet]
        //public async Task<IActionResult> GetProducts()

        //{
        //    var products = await _context.Products.ToListAsync();
        //    return Ok(products);
        //}
        [HttpGet]
        public ViewResult GetProducts()
        {
            #region Eski_Hali
            //var result = from p in _context.Products
            //             join c in _context.Categories
            //             on p.CategoryId equals c.CategoryId
            //             select new ProductModel
            //             {
            //                 ProductId = p.ProductId,
            //                 ProductName = p.ProductName,
            //                 CategoryName = c.CategoryName,
            //                 UnitPrice = p.UnitPrice
            //             };
            //return View(result); 
            #endregion
            List<Productnew> listOfProduct = _context.Products.ToList();
            return View(listOfProduct);
        }
        [HttpGet("Details")]
        public ViewResult GetProductsV2()
        {
            var result = from p in _context.Products
                         join c in _context.Categories
                         on p.CategoryId equals c.CategoryId
                         select new ProductModel
                         {
                             ProductId = p.ProductId,
                             ProductName = p.ProductName,
                             CategoryName = c.CategoryName,
                             UnitPrice = p.UnitPrice
                         };
            return View(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(v=>v.ProductId ==id);

            //string json = JsonConvert.SerializeObject(product);
            //var generatedcsResponce = JsonConvert.DeserializeObject(json);

            //Dictionary<string, ProductModel> dictionary = JsonConvert.DeserializeObject<Dictionary<string, ProductModel>>(json);
            
            //// Create empty excel file with a sheet
            //ExcelFile workbook = new ExcelFile();
            //ExcelWorksheet worksheet = workbook.Worksheets.Add("Products");

            //// Define header values
            //worksheet.Cells[0, 0].Value = "ProductId";
            //worksheet.Cells[0, 1].Value = "ProductName";
            //worksheet.Cells[0, 2].Value = "UnitPrice";
            //worksheet.Cells[0, 3].Value = "CategoryName";

            //// Write deserialized values to a sheet
            //int row = 0;
            //foreach (ProductModel productModel in dictionary.Values)
            //{
            //    worksheet.Cells[++row, 0].Value = productModel.ProductId;
            //    worksheet.Cells[row, 1].Value = productModel.ProductName;
            //    worksheet.Cells[row, 2].Value = productModel.UnitPrice;
            //    worksheet.Cells[row, 3].Value = productModel.CategoryName;
            //}

            //// Save excel file
            //workbook.Save("JsonToExcel.xlsx");
            return Ok(product);
        }


    }
}
