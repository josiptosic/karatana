using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace karatana
{
    class Program
    {
        static void Main(string[] args)
        {
            Stats stats1 = new Stats()
            {
                HealthPt = 100,
                Agility = 40,
                Strength = 10
            };

            Stats stats2 = new Stats()
            {
                HealthPt = 100,
                Agility = 40,
                Strength = 10
            };

            Player p1 = new Player(stats1);
            Enemy p2 = new Enemy(stats2);

            p1.Name = "Iks";
            p2.Name = "Oks";

            Item jabuka = new Item(new Stats());

            HealBuff h = new HealBuff();
            h.Duration = 10;
            p2.Buffs.Add(h);

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            Console.WriteLine($"\t\t\t Player: {p1.Health.HealthPt}, Enemy: {p2.Health.HealthPt}.");

            Character pobjednik = GameManager.Conflict(p1, p2);
            Console.WriteLine($"Pobjednik je {pobjednik.Name}!");

            Console.Read();
        }       
    }
}
