using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karatana
{
    public class FistSpell : Spell
    {
        public FistSpell()
        {
            Name = "Fist Spell";
        }

        public override void CastSpell(Character from, IDamageable to)
        {
            var rollResult = GameManager.rnd.Next(0, 101);
            Console.ForegroundColor = ConsoleColor.Magenta;
            if (rollResult < from.Stats.Agility) 
            { 
                to.RecieveDamage((from.Stats.Strength) * 2);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Krita u Bila!"); }
            else to.RecieveDamage(from.Stats.Strength);
        }

        public override bool Requirements(Character ch1)
        {
            return ch1.Stats.Strength > 0;
        }
    }
}
