﻿using EMS.ApplicationCore.Interfaces.Repositories;
using EMS.ApplicationCore.Interfaces.Services;
using EMS.ApplicationCore.Models;
using EMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EMS.ApplicationCore.Services
{
    public class ShiftService : BaseService<ShiftModel, MasterShift, IAsyncRepository<MasterShift>>, IShiftService
    {
        public ShiftService(IAsyncRepository<MasterShift> repository) 
            : base(repository)
        {
        }
    }
}