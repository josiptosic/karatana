using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace karatana
{
    public class Player : Character, ICombat
    {
        public Player(int HealthPt) : base(HealthPt)
        {
            Target = default(Character);
        }

        public void Decision() 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Choose spell:");

            for (int i = 0; i < Spells.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (i % 2 == 0) 
                { 
                    Console.Write($"Spell {i + 1}: {Spells[i].Name}"); 
                }
                else if (i % 2 == 1) 
                { 
                    Console.WriteLine($"\t\t\tSpell {i + 1}: {Spells[i].Name}"); 
                }
                
            }

            Console.WriteLine();

            string d = Console.ReadLine();

            
            int broj = 0;
            int.TryParse(d, out broj);

            if (!int.TryParse(d, out broj)) Decision();

            if (broj - 1 >= 0 && broj - 1 < Spells.Count)
            {
                var selectedSpell = this.Spells[broj - 1];

                if (selectedSpell.Requirements(this))
                {
                    selectedSpell.CastSpell(this, Target);
                }
            } 
            else 
            {
                Console.WriteLine("Invalid selection!");
                Decision(); 
            }
        }

        public IDamageable Target { get; set; }      
    }
}
