using System;

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

        public string Name { get { return name; } set { name = value; } }
        public int Value { get { return value; } set { this.value = value; } }
        public string Description { get { return description; } set { description = value; } }
        public bool Quest { get { return quest; } set { quest = value; } }
        public bool Consumable { get { return consumable; } set { consumable = value; } }
    }
}
