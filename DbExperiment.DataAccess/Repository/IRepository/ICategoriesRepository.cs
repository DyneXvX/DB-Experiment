﻿using DbExperiment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbExperiment.DataAccess.Repository.IRepository
{
    public interface ICategoriesRepository
    {
        Task<int> Update(Categories categories);
    }
}
