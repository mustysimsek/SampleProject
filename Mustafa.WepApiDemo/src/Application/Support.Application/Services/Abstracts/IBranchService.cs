using Support.Domain.Entities;
using Support.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Support.Application.Services.Abstracts
{
    public interface IBranchService
    {
        Task<List<BranchProductModel>> GetBranchProduct(int currentCode);
    }
}
