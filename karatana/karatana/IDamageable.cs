using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karatana
{
    public interface IDamageable
    {
        int HealthPt { get; set; }
        void HealthChange(int pt);       
    }
}
