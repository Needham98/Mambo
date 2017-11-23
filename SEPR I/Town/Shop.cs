using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace SEPR_I
{
    public static class Shop
    {
        public static List<Item> item_data = new List<Item>();
        private static int value_temp;
        private static bool quest_temp;
        private static bool consumable_temp;

        public static void ParseCSV()
        {
            using (TextFieldParser parser = new TextFieldParser(@System.IO.Path.GetFullPath(@"..\..\Town\items.csv")))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(", ");
                parser.TrimWhiteSpace = true;

                while (!parser.EndOfData)
                {
                    string[] row = parser.ReadFields()[0].Split(',');
                    Int32.TryParse(row[1], out value_temp);
                    quest_temp = row[3].Equals("1") ? true : false;
                    consumable_temp = row[4].Equals("1") ? true : false;
                    item_data.Add(new Item(row[0], value_temp, row[2], quest_temp, consumable_temp));

                    Console.WriteLine("{0}{1}{2}", item_data.Last().Name, " ", item_data.Last().Value); //testing
                }
            }
        }

        public static void buy(Item item, Player player) // or pass in item as string?, Player is there 
        {
            if (player.Gold >= item.Value)
            {
                //Player.addToInventory(item); //method yet to be made
                player.Gold -= item.Value;
            }
        }

        public static void sell(Item item, Player player) // or pass in item as string?
        {
            //Player.removeFromInventory(item); //method yet to be made
            player.Gold += (int)Math.Round(item.Value * 0.5); //0.5 arbitrary atm
        }
    }
}