using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace karatana
{
    public class GameManager
    {
        Player p1 = new Player();
        Player p2 = new Player();
        Random rnd = new Random();

        public object Conflict(Player p1, Player p2)
        {
            while (true) 
            {
                p1.HealthChange(-(rnd.Next(5, 10)));
                p2.HealthChange(-(rnd.Next(5, 10)));
                Thread.Sleep(1000);
                Console.WriteLine($" Player 1: {p1.HealthPt}, Player 2: {p2.HealthPt}.");
                if (p1.HealthPt <= 0 || p2.HealthPt <= 0) break;
            }
            if (p1.HealthPt <= 0) return p2;
            else if (p2.HealthPt <= 0) return p1;
            else return null;
        }

        
        
    }
}
