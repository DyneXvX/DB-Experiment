using DbExperiment.Models;
using System.Threading.Tasks;

namespace DbExperiment.DataAccess.Repository.IRepository
{
    public interface IBooksRepository 
    {

        Task<int> Update(Books books);
    }
}
