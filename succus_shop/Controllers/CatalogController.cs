using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using succus_shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;


namespace succus_shop.Controllers
{
    public class CatalogController : Controller
    {
        private readonly SuccuDbContext _SuccuDbContext;
        public CatalogController(SuccuDbContext succuDbContext)
        {
            _SuccuDbContext = succuDbContext;
        }
        public IActionResult Catalog()
        {
            if (User.Identity.IsAuthenticated)
            {
                string role = User.FindFirst(x => x.Type == ClaimsIdentity.DefaultRoleClaimType).Value;
                ViewBag.User = role;
            }
            else
            {
                ViewBag.User = "customer";
            }

            ViewData.Model = _SuccuDbContext.SuccuModels.OrderBy(item => item.Id).ToList();
            return View();
        }
        
        [HttpGet]
        public IActionResult EditDb(int id)
        {
            ViewData.Model = _SuccuDbContext.SuccuModels.FirstOrDefault(i => i.Id == id);
            return View();
        }
        [HttpPost]
        public IActionResult EditDb(SuccuModel succuModel)
        {
            var fromDb = _SuccuDbContext.SuccuModels.Find(succuModel.Id);
            fromDb.Name = succuModel.Name;
            fromDb.Description = succuModel.Description;
            fromDb.Species = succuModel.Species;
            fromDb.Size = succuModel.Size;
            fromDb.IsAvialible = succuModel.IsAvialible;
            _SuccuDbContext.SaveChanges();
            return View();
        }
        [HttpGet]
        public IActionResult AddInDb()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddInDb(SuccuModel succuModel)
        {
            
            _SuccuDbContext.SuccuModels.Add(succuModel);
            _SuccuDbContext.SaveChanges();
            return RedirectToPage("/Catalog");

        }

        public void DeleteFromDb(int id)
        {

            var fromDb = _SuccuDbContext.SuccuModels.Find(id);

            if (fromDb != null)
            {
                _SuccuDbContext.SuccuModels.Remove(fromDb);
                _SuccuDbContext.SaveChanges();
            }

            RedirectToPage("/Catalog");
        }
    }
}
