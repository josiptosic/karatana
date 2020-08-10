using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karatana
{
    public abstract class Damageable
    {
        public Damageable()
        {
            HealthPt = 100;
        }

        public int MaxHit { get; set; }
        public const int MinHit = 0;
        public int HealthPt { get; set; }

        public virtual void HealthChange(int pt)
        {
            HealthPt += pt;
            if (HealthPt >= MaxHit) { HealthPt = MaxHit; }
            else if (HealthPt <= MinHit) { HealthPt = MinHit; }
        }
    }
}
