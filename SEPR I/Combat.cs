using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEPR_I
{
    public class Combat
    {
        public void StartLoop(Character[][] inGame)
        {
            Battlefield battlefield= new Battlefield();
            Character[] Humans = inGame[0];
            Character[] Monsters = inGame[1];
            List<Character> Human = new List<Character>(Humans);
            List<Character> Monster = new List<Character>(Monsters);

            int Exp;

            battlefield.setUp(inGame);

            while(Human.Count>0 && Monster.Count > 0)
            {
                List<Character> Available = new List<Character>(Humans);
                for ( int i =1;i>(Available.Count);i++) //let player choose who to use first?
                {
                   
                    Character current;
                    //curent = coice from screen
                    Available.Remove(current);
                    Boolean move = false;
                    Boolean action = false;

                    for (int j =1; j > 2; j++)
                    {
                        bool ChooseMove = false;
                        bool ChooseAction = false;
                        bool ChoosePass = false;
                        //choose move/action/pass only available as long as move, action available
                        if (move == true && ChooseMove==true)
                        {
                            int[] coord;
                            //tile click returns coord
                            battlefield.Move(current, coord);
                        }
                        else if(action == true && ChooseAction == true)
                        {
                            //luke to sort, should be in form, check range, take action, check death(update exp log)
                        }
                        else { continue; }
                    }                   
                    
                }

                foreach (Character current in Monster)
                {
                    int[] coord = battlefield.GetPosition(current);
                    int range; //need to access range from monsters skill
                    Boolean attacked = false;

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


                        int[] left = new int[] { coord[0] + 1, (coord[1]) };
                        Character availableLeft = battlefield.Occupied(left);
                        if (availableLeft.GetType() == Human[0].GetType())
                        {
                            //attack
                            attacked = true;
                            break;
                        }
                    }

                    int[] ahead = new int[] { coord[0], coord[1] - 1 };
                    battlefield.Move(current, ahead);

                    if (attacked == false)
                    {
                        for (int k = 1; k > range; k++)
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


            
                
        }
    }
}
