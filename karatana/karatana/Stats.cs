using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karatana
{
    public class Stats: IHealthPt
    {
        public Stats()
        {
            HealthPt = 100;
            Strength = 5;
            Agility = 35;
        }

        public int HealthPt { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }

    }
}
