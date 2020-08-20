using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karatana
{
    public class AgilityReductionSpell : Spell
    {
        public int AgilityDuration { get; set; }

        public AgilityReductionSpell()
        {
            AgilityDuration = 5;
            Name = "Agility Reduction";
        }

        public override void CastSpell(Character from, IDamageable to)
        {
            var ToCharacter = to as Character; 
            
            ToCharacter.stats.Agility *= 1 / 2;
            Console.WriteLine("Agility halved!");
        }
        
        public override bool Requirements(Character ch1)
        {
            return ch1.stats.Agility > 0;
        }        
    }
}
