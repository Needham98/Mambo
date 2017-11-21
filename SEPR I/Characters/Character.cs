using System;

namespace SEPR_I
{
    public class Character
    {
        private string Name;

        private int HP;
        private int MP;

        private int CurrentHP;
        private int CurrentMP;

        private int Acc;
        private int Str;
        private int Def;
        private int Agi;
        private int Cha;
        private int Kno;

        private int Level;

        private Abilities[] Abilities;
        
        

        public Character(string Name, int HP, int MP, int Acc, int Agi, int Str, int Def, int Cha, int Kno, int Level)
        {
            this.Name = Name;
            this.HP1 = HP;
            this.MP1 = MP;
            this.Acc1 = Acc;
            this.Str1 = Str;
            this.Def1 = Def;
            this.Agi1 = Agi;
            this.Cha1 = Cha;
            this.Kno1 = Kno;
            this.Level1 = Level;
            this.CurrentHP1 = HP;
            this.CurrentMP1 = MP;
        }

        public int HP1 { get => HP; set => HP = value; }
        public int MP1 { get => MP; set => MP = value; }
        public int CurrentHP1 { get => CurrentHP; set => CurrentHP = value; }
        public int CurrentMP1 { get => CurrentMP; set => CurrentMP = value; }
        public int Acc1 { get => Acc; set => Acc = value; }
        public int Str1 { get => Str; set => Str = value; }
        public int Def1 { get => Def; set => Def = value; }
        public int Agi1 { get => Agi; set => Agi = value; }
        public int Cha1 { get => Cha; set => Cha = value; }
        public int Kno1 { get => Kno; set => Kno = value; }
        public int Level1 { get => Level; set => Level = value; }
        internal Abilities[] Abilities1 { get => Abilities; set => Abilities = value; }
    }
}