using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEPR_I
{
    public class Item
    {
        private string name;
        private int value;
        private string description;
        private Boolean quest;
        private Boolean consumable;

        public Item(string name, int value, string description, Boolean quest, Boolean consumable)
        {
            this.Name = name;
            this.Value = value;
            this.Description = description;
            this.Quest = quest;
            this.Consumable = consumable;
        }

        public string Name { get => name; set => name = value; }
        public int Value { get => value; set => this.value = value; }
        public string Description { get => description; set => description = value; }
        public bool Quest { get => quest; set => quest = value; }
        public bool Consumable { get => consumable; set => consumable = value; }
    }
}
