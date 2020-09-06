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
    public class BooksRepository : Repository<Books>, IBooksRepository
    {
        private readonly ApplicationDbContext _db;

        public BooksRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

    }
}
