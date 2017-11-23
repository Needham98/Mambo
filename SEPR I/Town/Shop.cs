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
        static Items[] item_data = new Items[3];
        //^Size of 3 for testing.
        private static int value_temp;
        private static bool quest_temp;
        private static bool consumable_temp;

        public static void Parse_CSV()
        {
            using (TextFieldParser parser = new TextFieldParser(@System.IO.Path.GetFullPath(@"..\..\Town\items.csv")))
            //@"H:\SEPR\SEPR I\Town\items.csv"

            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(", ");
                parser.TrimWhiteSpace = true;
                while (!parser.EndOfData)
                {
                    string[] fieldRow = parser.ReadFields();
                    foreach (string fieldRowCell in fieldRow)
                    {
                        string[] row = fieldRowCell.Split(',');
                        Int32.TryParse(row[1], out value_temp);
                        Boolean.TryParse(row[3], out quest_temp);
                        Boolean.TryParse(row[4], out consumable_temp);
                        //quest_temp = str.Equals(row[3]) ? true : false;
                        item_data[0] = new Items(row[0], value_temp, row[2], quest_temp, consumable_temp);
                        Console.WriteLine(item_data[0].Name); //test
                            
                    }
                }
            }
        }
    }
}