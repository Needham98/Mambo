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
        private Boolean active;

        public Companion(string Name, int Level, int XP, College college, Subject subject, Boolean active)
           : base(Name, Level, XP, college, subject)
        {
            this.Active = active;
        }
        

        public Items[] ItemList1 { get => ItemList; }
        public bool Active { get => active; set => active = value; }

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
                    //if (i == 5) { new error }
                }
            }
        }

    }
    
}
