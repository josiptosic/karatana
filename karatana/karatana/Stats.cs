using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace karatana
{
    
    public class Stats: IHealthPt, IComparable, IComparable<Stats>, IComparable<Character>
    {
        public Stats()
        {}



        public int HealthPt { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }

        public static Stats operator+(Stats left, Stats right)
        {
            Stats result = new Stats();
            result.HealthPt = left.HealthPt + right.HealthPt;
            result.Strength = left.Strength + right.Strength;
            result.Agility = left.Agility + right.Agility;
            return result;
        }

        public static Stats operator -(Stats left, Stats right)
        {
            Stats result = new Stats();
            result.HealthPt = left.HealthPt - right.HealthPt;
            result.Strength = left.Strength - right.Strength;
            result.Agility = left.Agility - right.Agility;
            return result;
        }

        public override string ToString()
        {
            return string.Format("HealthPt {0} Strength {1} Agility {2}", this.HealthPt, this.Strength, this.Agility);
        }

        public int CompareTo(object obj)
        {
            var stat = obj as Stats;

            if (stat != null) 
            {
                if (stat.HealthPt == this.HealthPt) return 0;
                else if (stat.HealthPt > this.HealthPt) return -1;
                else return 1;
            }
            else 
            {
                throw new InvalidCastException();
            }
        }

        public int CompareTo(Stats other)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Character other)
        {
            throw new NotImplementedException();
        }
    }
}
