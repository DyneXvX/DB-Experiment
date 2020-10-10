using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbExperiment.Data;
using DbExperiment.DataAccess.Repository.IRepository;
using DbExperiment.Models;
using Microsoft.EntityFrameworkCore;

namespace DbExperiment.DataAccess.Repository
{
    public class ManagerUserRepository : IManagerUserRepository
    {
        private readonly ApplicationDbContext _db;

        public ManagerUserRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<int> Update(ManagerUser managerUser)
        {
            var objFromDb = await _db.ManagerUser.FirstOrDefaultAsync(s => s.Id == managerUser.Id);

            if (objFromDb != null)
            {
                objFromDb.FirstName = managerUser.FirstName;
                objFromDb.LastName = managerUser.LastName;
            }

            return await _db.SaveChangesAsync();
        }
    }
}
