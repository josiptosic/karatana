using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace karatana
{
    public class GameManager
    {              
        public static Random rnd = new Random();

        public static Character Conflict(Player p1, Enemy p2)
        {           
            while (true) 
            {
                p1.Target = p2;
                p1.Decision();

                p2.Target = p1;
                p2.Decision();

                p1.OnTurnEnd();
                p2.OnTurnEnd();

                Thread.Sleep(500);

                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine($"\t\t\t Player: {p1.Stats.HealthPt}, Enemy: {p2.Stats.HealthPt}.");
                if (p1.Stats.HealthPt <= 0 || p2.Stats.HealthPt <= 0) break;
            }

            if (p1.Stats.HealthPt <= 0) return p2;
            else if (p2.Stats.HealthPt <= 0) return p1;
            else return default(Player);
        }                
    }
}
