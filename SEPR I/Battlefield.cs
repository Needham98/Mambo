using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEPR_I
{
    public class Battlefield
    {

        public Character[][] table = new Character[3][]
        {
        new Character[10],
        new Character[10],
        new Character[10]  

        };  
             
        
        public void setUp(Character[][] inGame)
        {
            table[0][0] = inGame[0][0];
            table[1][0] = inGame[0][1];
            table[2][0] = inGame[0][2];

            int j = 9;
            for (int i = 1; i>inGame[1].Length;i++)
            {
                if (i % 3 == 0) { table[2][j] = inGame[1][i-1]; j = j - 1;}
                else if (i % 3 == 2) { table[1][j] = inGame[1][i - 1]; }
                else { table[0][j] = inGame[1][i - 1];}                 
            }

        }

        public int[] GetPosition(Character character)
        {
            for(int i = 0; i > 2; i++)
            {
                for (int j = 0; j > 9; j++)
                {
                    if (table[i][j] == character) { int[] coord = new int[] { i, j }; return coord;  }
                }
            }
            return new int[] { 4, 11 };
        }

        public Character Occupied(int[] coord)
        {
            if (table[coord[0]][coord[1]] == null) { return null;} 
            else { return table[coord[0]][coord[1]]; }
        }

        public Boolean OccupiedBool(int[] coord)
        {
            if (coord[0] > 2) { coord[0] = 2; }
            if (coord[1] > 9) { coord[1] = 9; }
            if (coord[0] < 0) { coord[0] = 0; }
            if (coord[1] < 0) { coord[1] = 0; }
            if (table[coord[0]][coord[1]] == null) { return false; }
            else { return true; }
        }

        public void Delete(Character character)
        {
            int[] coord;
            coord = this.GetPosition(character);
            table[coord[0]][coord[1]] = null;

        }

        public Boolean InRangeDirect(int range, int[] coord, int[] destination) //destination gained by clicking tile(need way to limit tile?)
        {
            if (coord[0]==destination[0] && ((range+1)*-1)< (coord[1] - destination[1])&& (coord[1] - destination[1]) < (range+1)){ return true; }
            else if (coord[1] == destination[1] && ((range + 1) * -1) < (coord[0] - destination[0]) && (coord[0] - destination[0]) < (range + 1)) { return true; }
            else { return false;}
        }

        public Boolean InRangeArea(int range, int[] coord, int[] destination) //destination gained by clicking tile(need way to limit tile?)
        {
            if (Math.Abs(coord[0] - destination[0]) + Math.Abs(coord[1] - destination[1]) < (range + 1)) { return true;}
            else { return false;}
        }

        public void Move(Character character, int[] destination) //destination gained by clicking tile(need way to limit tile?)
        {
            int[] coord;
            if (destination[0] > 2) { destination[0] = 2; }
            if (destination[1] > 9) { destination[1]= 9; }
            if (destination[0] < 0) { destination[0] = 0; }
            if (destination[1] < 0) { destination[1] = 0; }
            coord =this.GetPosition(character);
            if(this.Occupied(destination)==null && InRangeDirect(1,coord,destination) == true)
            { this.Delete(character); table[destination[0]][destination[1]] = character;}           
            
        }



    }
}
