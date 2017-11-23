using System;

namespace SEPR_I
{
    public class Character
    {
        private string name;

        private int hP;
        private int mP;

        private int currenthP;
        private int currentmP;

        private int acc;
        private int str;
        private int def;
        private int agi;
        private int cha;
        private int kno;

        private int level;

        private Abilities[] abilities;
        
        public Character(string name, int hP, int mP, int acc, int agi, int str, int def, int cha, int kno, int level)
        {
            this.Name = name;
            this.HP = hP;
            this.MP = mP;
            this.Acc = acc;
            this.Str = str;
            this.Def = def;
            this.Agi = agi;
            this.Cha = cha;
            this.Kno = kno;
            this.Level = level;
            this.CurrenthP = hP;
            this.CurrentmP= mP;
        }

        public Character(string name, int level)
        {
            this.Name = name;
            this.Level = level;
        }

        public int HP { get => hP; set => hP = value; }
        public int MP { get => mP; set => mP = value; }
        public int CurrenthP { get => currenthP; set => currenthP = value; }
        public int CurrentmP { get => currentmP; set => currentmP = value; }
        public int Acc { get => acc; set => acc = value; }
        public int Str { get => str; set => str = value; }
        public int Def { get => def; set => def = value; }
        public int Agi { get => agi; set => agi = value; }
        public int Cha { get => cha; set => cha = value; }
        public int Kno { get => kno; set => kno = value; }
        public int Level { get => level; set => level = value; }
        internal Abilities[] Abilities1 { get => abilities; set => abilities = value; }
        public string Name { get => name; set => name = value; }
    }
}