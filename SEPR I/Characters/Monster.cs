using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEPR_I
{
    public class Monster : Character
    {
        private int EXP;
        private Item Loot;
        private Boolean Boss;
        //need ablities to be a skill so that it can be assigned here

        public Monster(string Name, int HP, int MP, int Acc, int Agi, int Str, int Def, int Cha, int Kno, int Level, int EXP,Item Loot, Boolean Boss)
            : base(Name, HP, MP, Acc, Agi, Str, Def, Cha, Kno, Level)
        {
            this.EXP1 = EXP;
            this.Loot1 = Loot;
            this.Boss1 = Boss;
        }

        public int EXP1 { get => EXP; set => EXP = value; }
        public Item Loot1 { get => Loot; set => Loot = value; }
        public bool Boss1 { get => Boss; set => Boss = value; }
    }
}
