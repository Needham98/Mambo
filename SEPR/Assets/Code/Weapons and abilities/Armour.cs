﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SEPR_I
{
    /*
     * The players can equip armour for extra strength bonus
     * this is still to be completed and is in layout for the next team
     */ 
    public class Armour:Item
    {
        private ArmourType armourType;
        private int defense;

        public Armour(string name, int value, string description, bool quest, Boolean consumable, ArmourType armourType, int Defense )
            :base (name, value, description, quest, consumable)
        {
            this.ArmourType = armourType;
            this.Defense = Defense;
        }

        public int Defense { get { return defense; }
            set
            {
                defense = value;
            }
        }
        public ArmourType ArmourType { get { return armourType; }
            set
            {
                armourType = value;
            }
        }
    }
}
