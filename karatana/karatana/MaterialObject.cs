﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karatana
{
    class MaterialObject : Damageable, IDamageable
    {
        public MaterialObject()
        {
            HealthPt = 100;
        }
    }
}
