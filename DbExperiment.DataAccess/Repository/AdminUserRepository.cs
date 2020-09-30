using DbExperiment.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbExperiment.Models;
using DbExperiment.Data;
using Microsoft.EntityFrameworkCore;

namespace DbExperiment.DataAccess.Repository
{
    public class AdminUserRepository : IAdminUserRepository
    {
        private readonly ApplicationDbContext _db;

        public AdminUserRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<int> Update(AdminUser adminUser)
        {
            var objFromDb = await _db.AdminUser.FirstOrDefaultAsync(s => s.Id == adminUser.Id);

            if (objFromDb != null)
            {
                objFromDb.FirstName = adminUser.FirstName;
                objFromDb.LastName = adminUser.LastName;
                
            }

            return await _db.SaveChangesAsync();
        }
    }
}
