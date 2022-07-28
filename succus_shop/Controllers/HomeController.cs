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

        public IActionResult Index()
        {
            return View();
        }


    }
}
