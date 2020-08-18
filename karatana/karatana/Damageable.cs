using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karatana
{
    public abstract class Damageable
    {
        public Damageable(int HealthPt)
        {
            this.HealthPt = HealthPt;
            this.MaxHit = HealthPt;
        }

        public int MaxHit { get; set; }
        public const int MinHit = 0;
        
        public int HealthPt { get; set; }
        
        public virtual void RecieveDamage(int pt)
        {
            HealthPt -= Math.Abs(pt);
            
            if (HealthPt <= MinHit) { HealthPt = MinHit; }
        }

        public virtual void Heal(int pt)
        {
            HealthPt += Math.Abs(pt);

            if (HealthPt >= MaxHit) { HealthPt = MaxHit; }
        }
    }
}
