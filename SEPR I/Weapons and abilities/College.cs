using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEPR_I
{
    public class College

    {
        private Colleges colleges;
        private string description;
        private int hP;
        private int mP;        
        private int acc;
        private int str;
        private int def;
        private int agi;
        private int cha;
        private int kno;

        public College(Colleges colleges, string description, int hP, int mP, int acc, int agi, int str, int def, int cha, int kno)
        {
            this.Colleges = colleges;
            this.Description = description;
            this.HP = hP;
            this.MP = mP;
            this.Acc = acc;
            this.Agi = agi;
            this.Str = str;
            this.Def = def;
            this.Cha = cha;
            this.Kno = kno;
        }

        public Colleges Colleges { get => colleges; set => colleges = value; }
        public string Description { get => description; set => description = value; }
        public int HP { get => hP; set => hP = value; }
        public int MP { get => mP; set => mP = value; }
        public int Acc { get => acc; set => acc = value; }
        public int Str { get => str; set => str = value; }
        public int Def { get => def; set => def = value; }
        public int Agi { get => agi; set => agi = value; }
        public int Cha { get => cha; set => cha = value; }
        public int Kno { get => kno; set => kno = value; }
    }
}
