using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karatana
{


    public class Enemy : Character, ICombat
    {
        public Enemy(int HealthPt) : base(HealthPt)
        {
            Spells = new List<Spell>();
            Spells.Add(new FistSpell());
            Spells.Add(new AgilityReductionSpell());
            Spells.Add(new FistSpell());
            Spells.Add(new FistSpell());
            Spells.Add(new FistSpell());
            Spells.Add(new FistSpell());
            Strength = 5;
            Agility = 20;
        }

        public void Decision()
        {
            var selectedSpell = this.Spells[GameManager.rnd.Next(0, this.Spells.Count)];
            if (selectedSpell.Requirements(this))
            {
                selectedSpell.CastSpell(this, Target);

            }
        }

        public IDamageable Target { get; set; }

    }
}
