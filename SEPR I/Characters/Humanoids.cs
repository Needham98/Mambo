using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEPR_I
{
    public class Humanoids : Character
    {
        private int XP;
        private College College;
        private Subject Subject;
        private Weapon weapon;
        private Armour Armour;


        public Humanoids(string Name, int HP, int MP, int Acc, int Agi, int Str, int Def, int Cha, int Kno, int Level, int XP, College College, Subject Subject)
               : base(Name, HP, MP, Acc, Agi, Str, Def, Cha, Kno, Level)
        {
            this.XP1 = XP;
            this.College1 = College;
            this.Subject1 = Subject;
        }

        public College College1 { get => College; set => College = value; }
        public Subject Subject1 { get => Subject; set => Subject = value; }
        public Weapon Weapon { get => weapon; set => weapon = value; }
        public int XP1 { get => XP; set => XP = value; }
    }
}