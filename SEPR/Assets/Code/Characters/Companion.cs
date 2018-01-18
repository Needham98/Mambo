using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SEPR_I
{

    /*
     * Companions are player controlled characters in addition to the MC which can be collected around the world
     * they have all features of a humanoid as well as class and abilities.
     */ 
    class Companion:Humanoid
    {
        private Item[] ItemList = new Item[5];
        private Boolean active;

        public Companion(string Name, int Level, int XP, string college, Subject subject, Boolean active)
           : base(Name, Level, XP, college, subject)
        {
            this.Active = active;
        }
        

        public Item[] ItemList1 {
            get
            {
                return ItemList;
            }
        }
        public bool Active { get { return active; }
            set
            {
                active = value;
            }
        }

        public void SetItem(Item x)
        {
            for (int i = 0; i < 5; i++)
            {
                if (ItemList[i] == null)
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
