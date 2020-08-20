using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace karatana
{
    public abstract class Character : Damageable
    {
        public Character(Stats stats):base(stats) 
        {
            this.stats = stats;

            Spells = new List<Spell>();
            Spells.Add(new AgilityReductionSpell());
            Spells.Add(new FistSpell());
            Spells.Add(new AgilityReductionSpell());

            Buffs = new List<BuffEvent>();

            
        }

        const int HealthPerPtOfStamina = 10;

        public string Name { get; set; }

        public List<Spell> Spells;
        public List<BuffEvent> Buffs;

        public Stats stats { get; set; }

        public void OnTurnEnd() 
        {
            for (int i = Buffs.Count - 1; i >= 0; i--) 
            {
                Buffs[i].Duration--;
                Buffs[i].Tick(this);

                if(Buffs[i].Duration <= 0) 
                {
                    Buffs[i].Removed();
                    Buffs.Remove(Buffs[i]);
                }  
            }
        }

        
    }
}
