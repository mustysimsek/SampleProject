using Microsoft.EntityFrameworkCore;
using Support.Application.Services.Abstracts;
using Support.Domain.Entities;
using Support.Domain.Models;
using Support.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Support.Application.Services.Concretes
{
    public class BranchService : IBranchService
    {
        private readonly BevBreadDBContext _dbContext;

        public BranchService(BevBreadDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<BranchProductModel>> GetBranchProduct(int currentCode)
        {
            var list = from p in _dbContext.STProduct
                       join mp in _dbContext.MTProductCategory on p.FKCategoryId equals mp.PKProductCategoryId
                       join pv in _dbContext.STProductVariant on p.PKProductId equals pv.FKProductId
                       join bpr in _dbContext.STBranchProductRelation on p.PKProductId equals bpr.FKProductId
                       join b in _dbContext.STBranch on bpr.FKBranchId equals b.PKBranchId
                       where b.CurrentCode == currentCode
                       select new BranchProductModel
                       {
                           PKBranchId = b.PKBranchId,
                           BranchName = b.Name,
                           CurrentCode = b.CurrentCode,
                           PKProductId = p.PKProductId,
                           ProductCode = p.ProductCode,
                           ProductName = p.Name,
                           PKProductVariantId = pv.PKProductVariantId,
                           ProductVariantCode = pv.ProductVariantCode,
                           CategoryId = mp.PKProductCategoryId,
                           CategoryName = mp.Name
                       };
            return await list.ToListAsync();
        }
    }
}
