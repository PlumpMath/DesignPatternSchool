﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsSchool
{
    public class NackademinFactory : SchoolAbstractFactory
    {
        public override IEducation CreateEducation()
        {
            return new NackademinEducation();
        }
    }
}
