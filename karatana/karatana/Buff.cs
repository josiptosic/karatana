using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karatana
{
    public delegate bool Buff(int duration);
    public abstract class BuffEvent
    {
        public virtual void Applied() { }

        public virtual void Removed() { }

        public virtual void Tick(Character c) 
        { 
            c.HealthPt+=2;
        }

        public int Duration { get; set; }
        public int _id;
   
    }
}
