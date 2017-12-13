using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEPR_I
{
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
        public static string Name { get => name; set => name = value; }
        public static string College { get => college; set => college = value; }
        public static string Subject { get => subject; set => subject = value; }
        public static int Gold { get => gold; set => gold = value; }
        public static int HP { get => hP; set => hP = value; }
        public static int MP { get => mP; set => mP = value; }
        public static int Acc { get => acc; set => acc = value; }
        public static int Str { get => str; set => str = value; }
        public static int Def { get => def; set => def = value; }
        public static int Agi { get => agi; set => agi = value; }
        public static int Cha { get => cha; set => cha = value; }
        public static int Kno { get => kno; set => kno = value; }
        public static List<int> XpPerLevel { get => xpPerLevel; set => xpPerLevel = value; }
    }
}
