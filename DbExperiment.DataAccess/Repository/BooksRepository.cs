using System.Threading.Tasks;
using DbExperiment.Data;
using DbExperiment.DataAccess.Repository.IRepository;
using DbExperiment.Models;
using Microsoft.EntityFrameworkCore;

namespace DbExperiment.DataAccess.Repository
{
    public class BooksRepository : IBooksRepository
    {
        private readonly ApplicationDbContext _db;

        public BooksRepository(ApplicationDbContext db) 
        {
            _db = db;
        }

        public async Task<int> Update(Books books)
        {
            var objFromDb = await _db.Books.FirstOrDefaultAsync(s => s.Id == books.Id);

            if (objFromDb != null)
            {
                objFromDb.ISBN = books.ISBN;
                objFromDb.Price = books.Price;
                objFromDb.Title = books.Title;
                objFromDb.Category = books.Category;
                
            }

            return await _db.SaveChangesAsync();

        }
    }
}
