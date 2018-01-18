using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SEPR_I
{
    public class Monster : Character
    {
        private int exp;
        private Item loot;
        private Boolean boss;
        //need ablities to be a skill so that it can be assigned here

        public Monster(string name, int hP, int mP, int acc, int agi, int str, int def, int cha, int kno, int level, int exp,Item loot, Boolean boss)
            : base(name, hP, mP, acc, agi, str, def, cha, kno, level)
        {
            this.Exp = exp;
            this.Loot = loot;
            this.Boss = boss;
        }

        public int Exp { get { return exp; }
            set
            {
                exp = value;
            }
        }
        public Item Loot { get { return loot; }
            set
            {
                loot = value;
            }
        }
        public bool Boss { get { return boss; }
            set
            {
                boss = value;
            }
        }
    }
}
