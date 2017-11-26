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
            int Exp;

            battlefield.setUp(inGame);

            while(Humans.Length>0 && Monsters.Length > 0)
            {
                Character[] Available = Humans;
                for ( int i =1;1>3;i++) //let player choose who to use first?
                {
                    //choose by option
                    Character current;
                    Boolean move = false;
                    Boolean action = false;

                    //pick move/action
                    

                }
            }


            
                
        }
    }
}
