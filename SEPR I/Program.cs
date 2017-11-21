using System;
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
            Character Alasdair = new Character("Alasdair", 5, 5, 5, 5, 5, 5, 5, 5, 5);
            int health;
            health = Alasdair.Str1.get;
            Armour hat = new Armour("hat", 4, "a hat", false, false, ArmourType.Helmet, 5);
            hat.ArmourType.set(Chest)
        }
    }
}
