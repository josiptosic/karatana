using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace karatana
{
    public static class Extensions
    {
        public static int Sum(this int number1, int number2) 
        {
            return number1 + number2;
        }

        public static Stats AddStats(this Stats s1, Stats s2)
        {
            s1.HealthPt += s2.HealthPt;
            s1.Agility += s2.Agility;
            s1.Strength += s2.Strength;
            return s1;
        }

        public static Damageable RecieveDamage(this Damageable d1,  int damage)
        {
            d1.RecieveDamage(damage);
            return d1;
        }
    }
}
