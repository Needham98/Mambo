using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEPR_I
{
    public class Weapon:Items
    {
        private Weapons weapons;
        private int str;
        private int agi;
        private int acc;
        private int mp;
        private int hands;

        public Weapon(string name, int value, string description, bool quest, bool consumable, Weapons weapons, int hands, int str, int agi, int acc, int mp)
            : base(name, value, description, quest, consumable)
        {
            this.hands = hands;
            this.Str = str;
            this.Agi = agi;
            this.acc = acc;
            this.mp = mp;
        }

        public int Str { get => str; set => str = value; }
        public int Agi { get => agi; set => agi = value; }
    }
}
