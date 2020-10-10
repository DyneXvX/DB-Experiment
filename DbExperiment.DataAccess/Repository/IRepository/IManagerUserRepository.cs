using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbExperiment.Models;

namespace DbExperiment.DataAccess.Repository.IRepository
{
    public interface IManagerUserRepository
    {
        Task<int> Update(ManagerUser managerUser);
    }
}
