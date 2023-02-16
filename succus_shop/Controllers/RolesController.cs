using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using succus_shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace succus_shop.Controllers
{
    public class RolesController : Controller
    {
        private readonly SuccuDbContext _context;

        public RolesController(SuccuDbContext succuDbContext)
        {
            _context = succuDbContext;
        }
     
        public IActionResult UserList() {
            ViewData.Model = _context.Users.OrderBy(item => item.Id).ToList();
            return View();
        }

        [Authorize]
        public IActionResult Index()
        {
            ViewData.Model = _context.Roles.OrderBy(item => item.Id).ToList();

            return View();
        }
        public IActionResult Create() => View();


        [HttpGet]
        public IActionResult Edit(int id)
        {
            var identity = (ClaimsIdentity)User.Identity;
            var user = _context.Users.FirstOrDefault(i => i.Id == id);
            var rolename = User.FindFirst(x => x.Type == ClaimsIdentity.DefaultRoleClaimType).Value;
            var role = _context.Roles.SingleOrDefault(r => r.Name == rolename);
            ViewBag.Roles = _context.Roles;
            ViewBag.count = _context.Roles.Count();
            ChangeRoleViewModel model = new ChangeRoleViewModel
            {
                User = user,
                Role = role            
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(ChangeRoleViewModel userModel)
        {
            
            var fromDb = _context.Users.Find(userModel.User.Id);
            fromDb.Role = userModel.User.Role;
            var Role = _context.Roles.SingleOrDefault(r => r.Name == userModel.User.Role.Name);
            fromDb.RoleId = Role.Id;
            _context.SaveChanges();
            return RedirectToAction("UserList");
        }
        /*[HttpPost]
        public async Task<ActionResult> Delete(string id)
        {

            return RedirectToAction("Index");
        }*/


    }
}
