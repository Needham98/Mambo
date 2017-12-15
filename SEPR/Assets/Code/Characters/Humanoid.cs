namespace SEPR_I
{
    public class Humanoid : Character
    {
        private int xP;
        private int gold = 0; //assuming gold is 0 on object instantiation
        private Subject subject;
        private Weapon weapon;
        private Armour armour;


        public Humanoid(string name, int level, int xP, string college, Subject subject)
               : base(name, level)
        {
            this.xP = xP;
        }

        public Subject Subject { get { return subject; } set { subject = value; } }
        public Weapon Weapon { get { return weapon; } set { weapon = value; } }
        public int XP { get { return xP; } set { xP = value; } }
        public int Gold { get { return gold; } set { gold = value; } }

        public void LevelUp()
        {
            if (xP > Level * 1000)
            {
                //goto stat changing page
                this.Level = this.Level+1;
            }
        }
    }
}