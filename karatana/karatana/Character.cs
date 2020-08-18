using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karatana
{
    public abstract class Character : Damageable, IDamageable
    {
        public Character(int HealthPt) : base(HealthPt*HealthPerPtOfStamina)
        {
            Spells = new List<Spell>();
            Spells.Add(new AgilityReductionSpell());
            Spells.Add(new FistSpell());
            Spells.Add(new AgilityReductionSpell());
            Buffs = new List<BuffEvent>();
            
            Strength = 10;
            Agility = 30;

        }

        public void OnTurnEnd() 
        {
            
            for (int i=Buffs.Count-1;i>=0;i--) 
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

        const int HealthPerPtOfStamina = 10;

        public string Name { get; set; }
        public int Strength { get; set; }
        public int Stamina { get; set; }
        public int Agility { get; set; }

        public List<Spell> Spells;
        public List<BuffEvent> Buffs;
        
    }
}
