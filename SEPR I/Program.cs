﻿using System;
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
            Console.WriteLine("Testing Main", Environment.NewLine);
            Character Alasdair = new Character("Alasdair", 5, 5, 5, 5, 5, 5, 5, 5, 5);
            int health;
            health = Alasdair.Str;
            Alasdair.Str = 5;
            Armour hat = new Armour("hat", 4, "a hat", false, false, ArmourType.Helmet, 5);
            College Halifax = new College(Colleges.Halifax, "So far out of york most people forget about it, high chance of death down rape alley", 0, 0, 0, 0, -2, 2, 0, 0);
            //Humanoids Kieran = new Humanoids("Kkieran", 2, 0, Halifax,);

            //Character[] inGame = new Character[];
            //inGame[0] = Kieran;

            Subject Science = new Subject();
            College Derwent = new College(Colleges.Derwent, "Derwent", 0, 0, 0, 0, 0, 0, 0, 0);
            Player testPlayer = new Player("test", 1, 0, Derwent, Science);

            testPlayer.Gold += 5000;
            Shop.ParseCSV();
            Shop.buy(Shop.item_data[0], testPlayer);

            Character attack = new Character("attacking", 0);
            Character def = new Character("def", 0);
            Abilities.BasicHeal(ref attack, ref def);

            // CTRL-F5 TO TEST!
        }
    }
}
