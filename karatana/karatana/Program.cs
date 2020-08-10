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
            //var player = new Player();
            //IDamageable p1=player;
            //p1 = new MaterialObject();
            //player.i = 2;
            GameManager gm = new GameManager();
            Player p1 = new Player();
            Player p2 = new Player();
            p1.HealthPt = 1000;
            p2.HealthPt = 1000;
            p1.Name = "Iks";
            p2.Name = "Oks";
            
            



        }

        


    }
}
