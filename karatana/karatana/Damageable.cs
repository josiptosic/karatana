using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karatana
{
    public abstract class Damageable
    {
        public int MaxHit { get; set; }
        public const int MinHit = 0;
        public int HealthPt { get; set; }

        public void HealthChange(int pt)
        {
            if (HealthPt >= MaxHit) { HealthPt = MaxHit; }
            else if (HealthPt <= MinHit) { HealthPt = MinHit; }
            else HealthPt += pt;

        }
    }
}
