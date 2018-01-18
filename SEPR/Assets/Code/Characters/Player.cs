using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SEPR_I
{
    /*
     * the player is the main character and is the customisable character in the game and has an inventory of items as well as 
     * other abilities.
     */ 
    public static class Player
    {
        private static int gold = 0;
        private static int level = 1;
        private static int xp = 0;
        private static int hP = 0;
        private static int mP = 0;
        private static int acc = 0;
        private static int str = 0;
        private static int def = 0;
        private static int agi = 0;
        private static int cha = 0;
        private static int kno = 0;

        private static string name;
        private static string college;
        private static string subject;
        // ^ To be set by Unity events during character creation

        private static List<int> xpPerLevel = new List<int>{ 0, 200, 500, 1250, 2500, 5000 };

        private static List<Companion> companions = new List<Companion>();

        public static int XP
        {
            get { return xp; }
            set
            {
                if (value >= 0) {
                    xp += value;
                    try
                    {
                        if (xp >= xpPerLevel[level])
                        {
                            level += 1;
                            //xp = 0; //if xp gets reset on level up or persists
                            Console.WriteLine("Level up"); //test
                            Console.WriteLine(level); //test
                        }
                    }
                    catch (ArgumentOutOfRangeException) // or use Math.Max(0, value)
                    {
                        Console.WriteLine("Level cap"); //test
                    }
                }
                else
                {
                    throw new ArgumentOutOfRangeException("XP Cannot be negative");// assuming no xp debuffs
                }
            }
        }
        public static string Name { get { return name; }
            set
            {
                name = value;
            }
        }
        public static string College { get { return college; }
            set
            {
                college = value;
            }
        }
        public static string Subject { get { return subject; }
            set
            {
                subject = value;
            }
        }
        public static int Gold { get { return gold; }
            set
            {
                gold = value;
            }
        }
        public static int HP { get { return hP; }
            set
            {
                hP = value;
            }
        }
        public static int MP { get { return mP; }
            set
            {
                mP = value;
            }
        }
        public static int Acc { get { return acc; }
            set
            {
                acc = value;
            }
        }
        public static int Str { get { return str; }
            set
            {
                str = value;
            }
        }
        public static int Def { get { return def; }
            set
            {
                def = value;
            }
        }
        public static int Agi { get { return agi; }
            set
            {
                agi = value;
            }
        }
        public static int Cha { get { return cha; }
            set
            {
                cha = value;
            }
        }
        public static int Kno { get { return kno; }
            set
            {
                kno = value;
            }
        }
        public static List<int> XpPerLevel { get { return xpPerLevel; }
            set
            {
                xpPerLevel = value;
            }
        }
    }
}
