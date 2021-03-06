﻿using System.Linq;
using DbExperiment.Data;
using DbExperiment.Models;
using DbExperiment.Utility;
using Microsoft.AspNetCore.Identity;
using Serilog;

namespace DbExperiment.DataAccess.Initializer
{
    public class DbInitializer : IDbInitializer
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public DbInitializer(ApplicationDbContext db, UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public void Initialize()
        {
            if (_db.Roles.Any(r => r.Name == Constants.RoleAdmin)) return;
            



            _roleManager.CreateAsync(new IdentityRole(Constants.RoleAdmin)).GetAwaiter().GetResult();
            _roleManager.CreateAsync(new IdentityRole(Constants.RoleManager)).GetAwaiter().GetResult();
            _roleManager.CreateAsync(new IdentityRole(Constants.RoleUser)).GetAwaiter().GetResult();
            _roleManager.CreateAsync(new IdentityRole(Constants.RoleEmployee)).GetAwaiter().GetResult();

            _userManager.CreateAsync(new ApplicationUser
            {
                UserName = "Admin",
                Email = "admin@gmail.com"
            }, "Admin123").GetAwaiter().GetResult();

            var user = _db.ApplicationUser.FirstOrDefault(u => u.Email == "admin@gmail.com");

            _userManager.AddToRoleAsync(user, Constants.RoleAdmin).GetAwaiter().GetResult();
        }
    }
}