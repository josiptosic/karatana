using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karatana
{
    public abstract class Damageable:IDamageable
    {
        public Damageable(IHealthPt Health) 
        {
            this.Health = Health;
            
            this.MaxHit = this.Health.HealthPt;
        }

        public int MaxHit { get; set; }
        public const int MinHit = 0;
        public IHealthPt Health { get; set; }

        public virtual void RecieveDamage(int pt)
        {
            this.Health.HealthPt -= Math.Abs(pt);
            
            if (this.Health.HealthPt <= MinHit) { this.Health.HealthPt = MinHit; }
        }

        public virtual void Heal(int pt)
        {
            this.Health.HealthPt += Math.Abs(pt);

            if (this.Health.HealthPt >= MaxHit) { this.Health.HealthPt = MaxHit; }
        }        
    }
}
