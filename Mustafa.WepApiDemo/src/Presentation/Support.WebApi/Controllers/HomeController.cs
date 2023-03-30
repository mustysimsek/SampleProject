using Microsoft.AspNetCore.Mvc;
using Support.Persistence.Context;

namespace Support.WebApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _context;
        public HomeController(DataContext context)
        {
            _context = context;
        }

    }

}
