using System;
using System.Collections.Generic;
using UnityEngine;

namespace SEPR_I
{
    public class Combat
    {

        public static Action ChooseAction(Player current)
        {
            List<Action> possibleActions = new List<Action>();

            StreamReader r = new StreamReader(current. + ".txt");
            string actionStats = r.ReadLine();
            List<string> actions = new List<string>();
            while (actionStats != null)
            {
                actions.Add(actionStats);
                actionStats = r.ReadLine();
            }
            r.Close();

            foreach (string s in actions)
            {
                string[] stats = s.Split('|');
                Action a = new Action();
                a.damage = int.Parse(stats[0]);
                a.manaCost = int.Parse(stats[1]);
                a.name = stats[2];
                a.range = int.Parse(stats[3]);
                possibleActions.Add(a);

            }

            //Display possible actions to user
            //On click of action save action to new action below

            Action a = new Action();
            return a;


            //choose Action & get possible targets


        }

        private List<Character> getPossibleTargets(Battlefield b, int range, Character caster)
        {
            int[] position = b.GetPosition(caster);
            List<Character> targets = new List<Character>();
            foreach (Character[] line in b.table)
            {
                foreach (Character c in line)
                {
                    if (b.InRangeArea(range, b.GetPosition(caster), b.GetPosition(c)) || b.InRangeDirect(range, b.GetPosition(caster), b.GetPosition(c)))
                    {
                        targets.Add(c);
                    }
                }
            }

            return targets;

        }
        public void StartLoop(Character[] Humans) //new battlefield is set up with a given number of monsters and the human characters in use
        {
            Battlefield battlefield= new Battlefield();            
            Monster Close = new Monster("Close", 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, null, false);
            Monster Ranged = new Monster("Ranged", 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, null, false);
            Character [] Monsters = { Ranged, Ranged, Ranged, Close, Close,Close};
            List<Character> Human = new List<Character>(Humans);
            List<Character> Monster = new List<Character>(Monsters);
            Character[][] inGame = { Humans, Monsters };

            int Exp;

            battlefield.setUp(inGame);

            while(Human.Count>0 && Monster.Count > 0) //combat loop which continues until one side is defeated
            {
                List<Character> Available = new List<Character>(Humans); //this states which characters have been used this turn, list is filled and emtied over and over
                for ( int i =1;i>(Available.Count);i++) //let player choose who to use first?
                {
                   
                    Character current;
                    //curent = coice from screen
                    Available.Remove(current);
                    Boolean move = false;
                    Boolean action = false;

                    //in turn each charater can move and attack in any order

                    for (int j =1; j > 2; j++)
                    {
                        bool ChooseMove = false;
                        bool ChooseAction = false;
                        bool ChoosePass = false;
                        //choose move/action/pass only available as long as move, action available
                        if (move == false && ChooseMove==true)
                        {
                            int[] coord;
                            //tile click returns coord
                            battlefield.Move(current, coord);
                        }
                        else if(action == false && ChooseAction == true)
                        {
                            Action choice = ChooseAction(current);
                            List<Character> targets = getPossibleTargets(battlefield, choice.range, choice.caster);

                            //Choose target by on clicking on them on battlefield and add to list below that target
                            List<Character> chosenTargets = new List<Character>();
                            choice.targets = chosenTargets;
                            choice.doAction();

                            if (choice.damage > 0)
                            {
                                foreach (Character c in chosenTargets)
                                {
                                    c.CurrenthP -= choice.damage;

                                    if (CheckDeath(c))
                                    {
                                        //Character dead if here 
                                        battlefield.Delete(c);


                                    }
                                    else if (c.CurrenthP > c.HP)  //character been overhealed so move health back to max hp
                                        c.CurrenthP = c.HP;



                                }
                            }
                        }
                        else { continue; }
                    }                   
                    
                }

                foreach (Character current in Monster) //this is the monster ai, monsters are very simple and move and attack trying to inflict as much damadge as possible
                {
                    int[] coord = battlefield.GetPosition(current);
                    int range; //need to access range from monsters skill
                    Boolean attacked = false;
                    Boolean moved = false;

                    for (int k=1; k>range; k++)
                    {
                        //can we limit the value ahead it searches as its often going to search off the board now

                        int[] ahead = new int[] { coord[0], (coord[1] - k) };
                        Character availableAhead = battlefield.Occupied(ahead);
                        if (availableAhead.GetType() == Human[0].GetType())
                        {
                            //attack
                            attacked = true;
                            break;
                        }
                        int[] behind = new int[] { coord[0], (coord[1] + k) };
                        Character availableBehind = battlefield.Occupied(behind);
                        if (availableBehind.GetType() == Human[0].GetType())
                        {
                            //attack
                            attacked = true;
                            break;
                        }
                        int[] right = new int[] { coord[0] - k, (coord[1]) };
                        Character availableRight = battlefield.Occupied(right);
                        if (availableRight.GetType() == Human[0].GetType())
                        {
                            //attack
                            attacked = true;
                            break;
                        }


                        int[] left = new int[] { coord[0] + k, (coord[1]) };
                        Character availableLeft = battlefield.Occupied(left);
                        if (availableLeft.GetType() == Human[0].GetType())
                        {
                            //attack
                            attacked = true;
                            break;
                        }
                    }

                    if (attacked = true && range < 2) { moved = true; }
                    else if (attacked = true && range > 1)
                        {
                        int[] behind = new int[] { coord[0], (coord[1] + 1) };
                        int[] left = new int[] { coord[0] + 1, (coord[1]) };
                        int[] right = new int[] { coord[0] - 1, (coord[1]) };
                        if (battlefield.OccupiedBool(behind) == false) { battlefield.Move(current, behind); moved = true; }
                        else if(battlefield.OccupiedBool(left) == false) { battlefield.Move(current, left); moved = true; }
                        else if (battlefield.OccupiedBool(right) == false) { battlefield.Move(current, right); moved = true; }
                        else { moved = true; }
                    }
                    else { int[] ahead = new int[] { coord[0], (coord[1] - 1) }; battlefield.Move(current, ahead); moved = true; }
                    
                    if (attacked == false)
                    {
                        for (int k = 1; k > range; k++)
                        {
                            int[] ahead = new int[] { coord[0], (coord[1] - k) };
                            Character availableAhead = battlefield.Occupied(ahead);
                            if (availableAhead.GetType() == Human[0].GetType())
                            {
                                //attack
                                attacked = true;
                                break;
                            }
                            int[] behind = new int[] { coord[0], (coord[1] + 1) };
                            Character availableBehind = battlefield.Occupied(behind);
                            if (availableBehind.GetType() == Human[0].GetType())
                            {
                                //attack
                                attacked = true;
                                break;
                            }
                            int[] right = new int[] { coord[0] - 1, (coord[1]) };
                            Character availableRight = battlefield.Occupied(right);
                            if (availableRight.GetType() == Human[0].GetType())
                            {
                                //attack
                                attacked = true;
                                break;
                            }
                        }

                    
                }


            }
                //combat breaks
                if (Human.Count < 1)
                {
                    //load old save
                }
                else
                {
                    //run level up
                    //run loot give
                    //return to map
                }



            
                
        }


            public static bool doAction(Action a)
            {
                a.doAction();
                return true;
            }
            public static bool CheckDeath(Character c)
            {
                if (c.CurrenthP <= 0)
                    return true;
                else
                    return false;
            }
        }
}
