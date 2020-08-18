using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karatana
{
    public abstract class Spell 
    {
        public Spell()
        {}
        public abstract void CastSpell(Character ch1, IDamageable ch2);
        public abstract bool Requirements(Character ch1);
        
        List<Buff> buffs = new List<Buff>();
        List<Buff> debuffs = new List<Buff>();
        public string Name { get; set; }
       
    }
}
