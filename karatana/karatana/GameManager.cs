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
        
        Player p1 = new Player(100);
        Enemy p2 = new Enemy(100);
        
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

                Console.WriteLine($"\t\t\t Player: {p1.HealthPt}, Enemy: {p2.HealthPt}.");
                if (p1.HealthPt <= 0 || p2.HealthPt <= 0) break;
            }

            if (p1.HealthPt <= 0) return p2;
            else if (p2.HealthPt <= 0) return p1;
            else return default(Player);

        }

        
        
    }
}
