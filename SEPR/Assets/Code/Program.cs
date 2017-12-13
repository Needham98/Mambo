using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEPR_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing Main");
            Console.WriteLine();

            Armour hat = new Armour("hat", 4, "a hat", false, false, ArmourType.Helmet, 5);
            //Humanoids Kieran = new Humanoids("Kkieran", 2, 0, Halifax,);
            //Character[] inGame = new Character[];
            //inGame[0] = Kieran;

            testCharacter();
            testShop();
            testPlayer();

            // CTRL-F5 TO TEST!
        }

        static void testPlayer()
        {
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name + ":");
            Player.XP += 501;
            Console.WriteLine();
        }

        static void testShop()
        {
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name+":");
            Shop.ParseCSV();
            Console.WriteLine();
        }

        static void testCharacter()
        {
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name + ":");
            Character Alasdair = new Character("Alasdair", 5, 5, 5, 5, 5, 5, 5, 5, 5);
            int health;
            health = Alasdair.Str;
            Alasdair.Str = 5;

            Character attack = new Character("attacking", 0);
            Character def = new Character("def", 0);
            Abilities.BasicHeal(ref attack, ref def);
            Console.WriteLine();
        }
    }
}
