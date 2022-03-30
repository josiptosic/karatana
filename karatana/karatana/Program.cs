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
                HealthPt = 1000,
                Agility = 40,
                Strength = 30
            };

            Stats stats2 = new Stats()
            {
                HealthPt = 1000,
                Agility = 40,
                Strength = 30
            };

            //Player p1 = new Player(stats1);
            //Enemy p2 = new Enemy(stats2);

            //p1.Name = "Iks";
            //p2.Name = "Oks";

            //Item jabuka = new Item(new Stats());

            //HealBuff h = new HealBuff();
            //p2.Buffs.Add(h);

            //Console.BackgroundColor = ConsoleColor.DarkBlue;
            //Console.Clear();

            Stats s3 = stats1 + stats2;
            Stats s4 = stats1 - stats2;
            Console.WriteLine(s3);
            Console.WriteLine(s4);

            Console.WriteLine(s3.ToString());
            Console.WriteLine(s4.ToString());

            //int b1 = 1;
            //int b2 = 2;
            //int b3= b1.Sum(b2);

            //Console.WriteLine( b3 ); 


            //Console.WriteLine($"\t\t\t Player: {p1.Health.HealthPt}, Enemy: {p2.Health.HealthPt}.");

            //Character pobjednik = GameManager.Conflict(p1, p2);
            //Console.WriteLine($"Pobjednik je {pobjednik.Name}!");

            //Console.Read();
        }       
    }
}
