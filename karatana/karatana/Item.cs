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
            if (stats == null) this.stats = stats;
        }
        public string Name { get; set; }
        public enum EquipType
        {
            Consumable,
            Craftable,
            Equipable
        }
        public enum EquipmentSlot
        {
            Head,
            Torso,
            Hands,
            Legs
        }
        public List<BuffEvent> Buffs = new List<BuffEvent>();
        Stats stats = new Stats();
    }
}
