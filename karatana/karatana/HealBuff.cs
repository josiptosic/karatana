using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karatana
{
    public class HealBuff : BuffEvent
    {
        public override void Tick(Character c) 
        {
            c.Heal(2);
            Console.WriteLine($"{c.Name} +2");
        }
    }
}
