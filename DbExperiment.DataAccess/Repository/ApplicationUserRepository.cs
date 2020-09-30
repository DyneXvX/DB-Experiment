using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbExperiment.Data;
using DbExperiment.DataAccess.Repository.IRepository;
using DbExperiment.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace DbExperiment.DataAccess.Repository
{
    public class ApplicationUserRepository : IApplicationUserRepository
    {
        private readonly ApplicationDbContext _db;

        public ApplicationUserRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<int> Update(ApplicationUser applicationUser)
        {

            var objFromDb = await _db.ApplicationUser.FirstOrDefaultAsync(s => s.Id == applicationUser.Id);

            if (objFromDb != null)
            {
                objFromDb.FirstName = applicationUser.FirstName;
                objFromDb.LastName = applicationUser.LastName;
                objFromDb.StreetAddress = applicationUser.StreetAddress;
                objFromDb.City = applicationUser.City;
                objFromDb.State = applicationUser.State;
                objFromDb.PostalCode = applicationUser.PostalCode;
            }
            return await _db.SaveChangesAsync();
        }
    }
}
