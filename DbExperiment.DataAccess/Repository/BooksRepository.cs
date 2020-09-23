using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbExperiment.Data;
using DbExperiment.Models;
using DbExperiment.Repository.IRepository;

namespace DbExperiment.Repository
{
    public class BooksRepository : IBooksRepository
    {
        private readonly ApplicationDbContext _db;

        public BooksRepository(ApplicationDbContext db) 
        {
            _db = db;
        }

        public void Update(Books books)
        {
            var objFromDb = _db.Books.FirstOrDefault(s => s.Id == books.Id);
            if (objFromDb != null)
            {
                objFromDb.ISBN = books.ISBN;
                objFromDb.Price = books.Price;
                objFromDb.Title = books.Title;
                objFromDb.Category = books.Category;
                _db.SaveChanges();
            }
        }
    }
}
