using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karatana
{
    public interface ICombat
    {
        IDamageable Target { get; set; }
        void Decision();
    }
}
