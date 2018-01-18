using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEPR_I
{
    public class Action
    {

        public List<Character> targets { get; set; }
        public int damage { get; set; }
        public int manaCost { get; set; }
        public string name { get; set; }
        public Character caster { get; set; }
        public int range { get; set; }


        public Action()
        {
        }


        public void doAction()
        {
            if (caster.CurrentmP > manaCost)
            {
                foreach (Character c in targets)
                {
                    c.CurrenthP -= damage;
                }

                caster.CurrentmP -= manaCost;
            }
            else
            {
                //not enough mana
            }


        }


    }
}
