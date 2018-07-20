﻿using EMS.ApplicationCore.Interfaces.Repositories;
using EMS.ApplicationCore.Models;
using EMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EMS.ApplicationCore.Interfaces.Services
{
    public interface IJobService : IService<JobTitleModel, MasterJobTitle, IAsyncRepository<MasterJobTitle>>
    {
        Task<List<JobTitleModel>> GetByNameAsync(string name);
    }
}