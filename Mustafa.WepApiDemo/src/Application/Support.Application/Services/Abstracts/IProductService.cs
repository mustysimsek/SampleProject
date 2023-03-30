using Support.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Support.Application.Services.Abstracts
{
    public interface IProductService
    {
        Product GetProduct(string productCode);
    }
}
