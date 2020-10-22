using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbExperiment.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DbExperiment.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdministrationController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AdministrationController(RoleManager<IdentityRole> roleManager, ApplicationDbContext db)
        {
            _roleManager = roleManager;
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListUsers()
        {
            return View(_db.ApplicationUser.ToList());
        }

        [HttpGet]
        public IActionResult ListRoles()
        {
            var roles = _roleManager.Roles;
            return View(roles);
        }


    }
}
