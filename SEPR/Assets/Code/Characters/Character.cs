using System;
using UnityEngine;

namespace SEPR_I
{
    /*
     * This is the character class it is the base for any sort of moving character with stats.
     * Its made with a list of all possible stats for a character and their getters and setters
     */

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

        //private Abilities[] abilities;
        
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

        public string Name { get { return name; }
            set
            {
                name = value;
            }
        }

        public int HP { get { return hP; }
            set
            {
                hP = value;
            }
        }
        public int MP { get { return mP; }
            set
            {
                mP = value;
            }
        }        
        public int Acc { get { return acc; }
            set
            {
                acc = value;
            }
        }
        public int Str { get { return str; }
            set
            {
                str = value;
            }
        }
        public int Def { get { return def; }
            set
            {
                def = value;
            }
        }
        public int Agi { get { return agi; }
            set
            {
                agi = value;
            }
        }
        public int Cha { get { return cha; }
            set
            {
                cha = value;
            }
        }
        public int Kno { get { return kno; }
            set
            {
                kno = value;
            }
        }

        public int Level { get { return level; }
            set
            {
                level = value;
            }
        }
        //internal Abilities[] Abilities1 { get => abilities; set => abilities = value; }        

        public int CurrenthP { get { return currenthP; }
            set
            {
                currenthP = value;
            }
        }
        public int CurrentmP { get { return currentmP; }
            set
            {
                currentmP = value;
            }
        }
        public int Currentacc { get { return currentacc; }
            set
            {
                currentacc = value;
            }
        }
        public int Currentstr { get { return currentstr; }
            set
            {
                currentstr = value;
            }
        }
        public int Currentdef { get { return currentdef; }
            set
            {
                currentdef = value;
            }
        }
        public int Currentagi { get { return currentagi; }
            set
            {
                currentagi = value;
            }
        }
        public int Currentcha { get { return currentcha; }
            set
            {
                currentcha = value;
            }
        }
        public int Currentkno { get { return currentkno; }
            set
            {
                currentkno = value;
            }
        }
    }
}