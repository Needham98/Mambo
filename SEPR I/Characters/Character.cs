using System;

namespace SEPR_I
{
    public class Character
    {
        private string name;

        private int hP;
        private int mP;   
        private int acc;
        private int str;
        private int def;
        private int agi;
        private int cha;
        private int kno;

        private int currenthP;
        private int currentmP;
        private int currentacc;
        private int currentstr;
        private int currentdef;
        private int currentagi;
        private int currentcha;
        private int currentkno;

        private int level;

        private Abilities[] abilities;
        
        

        public Character(string name, int hP, int mP, int acc, int agi, int str, int def, int cha, int kno, int level)
        {
            this.Name = name;
            this.HP = hP;
            this.MP = mP;
            this.Acc = acc;
            this.str = str;
            this.Def = def;
            this.Agi = agi;
            this.Cha = cha;
            this.Kno = kno;
            this.Level = level;
            this.CurrenthP = hP;
            this.CurrentmP= mP;
            this.Currentacc = acc;
            this.Currentstr = str;
            this.Currentdef = def;
            this.Currentagi = agi;
            this.Currentcha = cha;
            this.Currentkno = kno;
        }

        public Character(string name, int level)
        {
            this.Name = name;
            this.Level = level;
        }

        public string Name { get => name; set => name = value; }

        public int HP { get => hP; set => hP = value; }
        public int MP { get => mP; set => mP = value; }        
        public int Acc { get => acc; set => acc = value; }
        public int Str { get => str; set => str = value; }
        public int Def { get => def; set => def = value; }
        public int Agi { get => agi; set => agi = value; }
        public int Cha { get => cha; set => cha = value; }
        public int Kno { get => kno; set => kno = value; }

        public int Level { get => level; set => level = value; }
        internal Abilities[] Abilities1 { get => abilities; set => abilities = value; }        

        public int CurrenthP { get => currenthP; set => currenthP = value; }
        public int CurrentmP { get => currentmP; set => currentmP = value; }
        public int Currentacc { get => currentacc; set => currentacc = value; }
        public int Currentstr { get => currentstr; set => currentstr = value; }
        public int Currentdef { get => currentdef; set => currentdef = value; }
        public int Currentagi { get => currentagi; set => currentagi = value; }
        public int Currentcha { get => currentcha; set => currentcha = value; }
        public int Currentkno { get => currentkno; set => currentkno = value; }
    }
}