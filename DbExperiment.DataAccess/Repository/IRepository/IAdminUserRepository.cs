using DbExperiment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbExperiment.DataAccess.Repository.IRepository
{
    public interface IAdminUserRepository
    {
        Task<int> Update(AdminUser adminUser);

        Task<int> Delete(AdminUser adminUser);
    }
}
