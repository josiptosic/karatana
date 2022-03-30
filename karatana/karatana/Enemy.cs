using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karatana
{
    public class Enemy : Character, ICombat
    {
        public Enemy(Stats stats) : base(stats)
        {
            Spells = new List<Spell>();
            Spells.Add(new FistSpell());
            Spells.Add(new AgilityReductionSpell());
            Spells.Add(new FistSpell());
            Spells.Add(new FistSpell());
            Spells.Add(new FistSpell());
            Spells.Add(new FistSpell());
        }

        public IDamageable Target { get; set; }

        public void Decision()
        {
            var selectedSpell = this.Spells[GameManager.rnd.Next(0, this.Spells.Count)];
            if (selectedSpell.Requirements(this))
            {
                selectedSpell.CastSpell(this, Target);
            }
        }
    }
}
