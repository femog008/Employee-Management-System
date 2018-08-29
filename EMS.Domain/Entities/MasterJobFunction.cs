﻿using System;
using System.Collections.Generic;

namespace EMS.Domain.Entities
{
    public partial class MasterJobFunction : BaseEntity
    {
        public MasterJobFunction()
        {
            EmployeeState = new HashSet<EmployeeState>();
        }

        public int JobFunctionId { get; set; }
        public string FunctionName { get; set; }
        public string FunctionDescription { get; set; }

        public ICollection<EmployeeState> EmployeeState { get; set; }
    }
}
