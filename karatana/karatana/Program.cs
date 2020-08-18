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
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            Player p1 = new Player(100);
            Enemy p2 = new Enemy(100);
            
            p2.Agility = 10;
            p2.Strength = 3;
            
            p1.Name = "Iks";
            p2.Name = "Oks";

            HealBuff h = new HealBuff();
            h.Duration = 100;
            p2.Buffs.Add(h);

            Console.WriteLine($"\t\t\t Player: {p1.HealthPt}, Enemy: {p2.HealthPt}.");

            Character pobjednik = GameManager.Conflict(p1, p2);
            Console.WriteLine($"Pobjednik je {pobjednik.Name}!");
            
       }

        


    }
}
