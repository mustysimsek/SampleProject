using Microsoft.AspNetCore.Mvc;
using Support.Application.Business.Abstracts;
using Support.Application.Business.Concretes;

namespace Support.WebApi.Controllers
{
    [Route("api/v1/branches")]
    public class BranchController : Controller
    {
        private readonly IBranchBusiness _branchBusiness;

        public BranchController(IBranchBusiness branchBusiness)
        {
            _branchBusiness = branchBusiness;
        }

        [HttpGet("{currentCode}")]
        public ViewResult GetBranchProductByCurrentCode([FromRoute] int currentCode)
        {
            return View(_branchBusiness.GetBranchProduct(currentCode));
        }
    }
}
