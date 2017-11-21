using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEPR_I
{
    public class Player : Humanoids
    {
        private Inventory Inventory;

        public Player(string Name, int HP, int MP, int Acc, int Agi, int Str, int Def, int Cha, int Kno, int Level, int XP, College College, Subject Subject)
            : base(Name, HP, MP, Acc, Agi, Str, Def, Cha, Kno, Level, XP, College, Subject)
        {
        }
    }
}
