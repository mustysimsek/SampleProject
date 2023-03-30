using Support.Application.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Support.Application.Business.Abstracts
{
    public interface IBranchBusiness
    {
        Task<List<GetBranchProductModel>> GetBranchProducts(int currentCode);
    }
}
