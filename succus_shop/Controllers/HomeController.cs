using Microsoft.AspNetCore.Mvc;
using succus_shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace succus_shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly SuccuDbContext _SuccuDbContext;
        public HomeController(SuccuDbContext succuDbContext)
        {
            _SuccuDbContext = succuDbContext;
        }
        public IActionResult Index()
        {
           ViewData.Model = _SuccuDbContext.SuccuModels.OrderBy(item => item.Id).ToList();
            return View();
        }
    }
}
