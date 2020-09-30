using System;
using System.Collections.Generic;
using System.Text;
using DbExperiment.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DbExperiment.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Books> Books { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<AdminUser> AdminUser { get; set; }


    }
}
