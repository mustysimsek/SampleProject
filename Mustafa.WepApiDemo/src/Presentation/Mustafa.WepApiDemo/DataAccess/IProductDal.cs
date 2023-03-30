using Mustafa.WepApiDemo.Entities;
using Mustafa.WepApiDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mustafa.WepApiDemo.DataAccess
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductModel> GetProductWithDetails();
    }
}
