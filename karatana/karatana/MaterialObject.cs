using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karatana
{
    public class MaterialObject : Damageable, IDamageable
    {
        public MaterialObject(int HealthPt) : base(HealthPt)
        {}  
    }
}
