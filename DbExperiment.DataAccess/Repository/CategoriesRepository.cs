using DbExperiment.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbExperiment.Data;
using DbExperiment.Models;
using Microsoft.EntityFrameworkCore;

namespace DbExperiment.DataAccess.Repository
{
    public class CategoriesRepository : ICategoriesRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoriesRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<int> Update(Categories categories)
        {
            var objFromDb = await _db.Categories.FirstOrDefaultAsync(s => s.Id == categories.Id);

            if (objFromDb != null)
            {
                objFromDb.Category = categories.Category;
            }
            return await _db.SaveChangesAsync();

        }

    }
}
