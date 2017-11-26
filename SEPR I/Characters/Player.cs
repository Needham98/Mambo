using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEPR_I
{
    public class Player : Humanoids
    {
        //private Inventory Inventory;

        public Player(string Name, int Level, int XP, College College, Subject Subject)
            : base(Name, Level, XP, College, Subject)
        {
            
        }
    }
}
