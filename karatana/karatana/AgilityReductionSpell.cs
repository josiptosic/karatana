using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karatana
{
    public class AgilityReductionSpell : Spell

    {
        public AgilityReductionSpell()
        {
            AgilityDuration = 5;
            Name = "Agility Reduction";
        }

        public override void CastSpell(Character from, IDamageable to)
        {
            var ToCharacter = to as Character; 
            
            ToCharacter.Agility *= 1 / 2;
            Console.WriteLine("Agility halved!");
        }

        
        public override bool Requirements(Character ch1)
        {
            return ch1.Agility > 0;
        }

        public int AgilityDuration { get; set;}

        
    }
}
