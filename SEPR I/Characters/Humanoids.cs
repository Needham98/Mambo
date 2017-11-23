using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEPR_I
{
    public class Humanoids : Character
    {
        private int xP;
        private College college;
        private Subject subject;
        private Weapon weapon;
        private Armour armour;


        public Humanoids(string name, int level, int xP, College college, Subject subject)
               : base(name, level)
        {
            this.xP = xP;
            this.College = college;
            this.Subject = subject;
            this.HP = 5 + college.HP;
            this.MP = 5 + college.MP;
            this.Acc = 5 + college.Acc;
            this.Agi = 5 + college.Agi;
            this.Str = 5 + college.Str;
            this.Def = 5 + college.Def;
            this.Agi = 5 + college.Agi;
            this.Cha = 5 + college.Cha;
            this.Kno = 5 + college.Kno;
        }

        public College College { get => college; set => college = value; }
        public Subject Subject { get => subject; set => subject = value; }
        public Weapon Weapon { get => weapon; set => weapon = value; }
        public int XP { get => xP; set => xP = value; }

        public void LevelUp()
        {
            if (xP > Level * 1000)
            {
                //goto stat changing page
                this.Level = this.Level+1;
            }
        }
    }
}