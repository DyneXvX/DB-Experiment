using DbExperiment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbExperiment.Repository.IRepository
{
    public interface IBooksRepository : IRepository<Books>
    {

        void Update(Books books);
    }
}
