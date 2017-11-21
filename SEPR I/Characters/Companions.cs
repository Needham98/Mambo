using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEPR_I
{
    class Companion:Humanoids
    {
        private Items[] ItemList = new Items[5];
        private Boolean Active;

        public Companion(string Name, int HP, int MP, int Acc, int Agi, int Str, int Def, int Cha, int Kno, int Level, int XP, College college, Subject subject, Boolean Active)
           : base(Name, HP, MP, Acc, Agi, Str, Def, Cha, Kno, Level, XP)
        {
            this.Active1 = Active;
        }
        

        public Items[] ItemList1 { get => ItemList; }
        public bool Active1 { get => Active; set => Active = value; }

        public void SetItem(Items x)
        {
            for (int i = 0; i < 5; i++)
            {
                if (ItemList[i] is null)
                {
                    ItemList[i] = x;
                    break;
                }
                else
                {
                    if (i == 5) { new error }
                }
            }
        }

    }
    
}
