using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karatana
{
    public interface IDamageable
    {
        IHealthPt Health { get; set; }
        void RecieveDamage(int pt);
        void Heal(int pt);
    }
}
