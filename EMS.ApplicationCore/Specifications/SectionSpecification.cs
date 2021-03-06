﻿using EMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EMS.ApplicationCore.Specifications
{
    public class SectionSpecification : BaseSpecification<MasterSection>
    {
        public SectionSpecification(Expression<Func<MasterSection, bool>> filter)
            : base(filter)
        {
            AddInclude(x => x.Department);
        }
    }
}
