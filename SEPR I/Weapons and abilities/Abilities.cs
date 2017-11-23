using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEPR_I
{
    public static class Abilities
    {
        public static void DefUpHealer(ref Character target, ref Character caster)
        {
            target.Def += 3;
            caster.CurrentmP -= 3;

        }

        public static void BasicHeal(ref Character target, ref Character caster)
        {
            target.CurrenthP += 3;
            caster.CurrentmP -= 2;

            if (target.CurrenthP > target.HP)
                target.CurrenthP = target.HP;
        }

        public static void DefDownHealer(ref Character target, ref Character caster)
        {
            target.Def -= 4;
            caster.CurrentmP -= 3;
        }

        public static void AttackUpHealer(ref Character target, ref Character caster)
        {
            target.Acc += 4;
            caster.CurrentmP -= 3;
        }

        public static void Sanctify(ref List<Character> targets, ref Character caster)
        {
            foreach (Character target in targets)
            {
                target.CurrenthP += 2;
                if (target.CurrenthP > target.HP)
                    target.CurrenthP = target.HP;
            }

            caster.CurrentmP -= 3;
        }

        public static void AccDownHealer(ref Character target, ref Character caster)
        {
            target.Acc -= 4;
            caster.CurrentmP -= 3;
        }

        public static void RogueVault(ref Character target, ref Character caster)
        {
            target.CurrenthP -= 2;
            caster.CurrentmP -= 2;
        }

        public static void WaspVenom(ref Character target, ref Character caster)
        {
            target.Str += 2;
            caster.CurrentmP -= 2;
        }

        public static void Flurry(ref Character target, ref Character caster)
        {
            target.CurrenthP -= 1;
            target.CurrenthP -= 1;
            target.CurrenthP -= 1;
            caster.CurrentmP -= 2;
        }







    }
}

