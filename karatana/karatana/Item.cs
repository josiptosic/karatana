using karatana.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karatana
{
    public class Item
    {
        public Item(Stats stats = null)
        {
            stats = new Stats();
            if (stats == null) this.stats = stats;
        }
        public string Name { get; set; }
        
        public List<BuffEvent> Buffs = new List<BuffEvent>();

        EquipmentSlot Slot;

        EquipType Type;

        Stats stats;
    }
}
