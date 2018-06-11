using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougueLike
{
    class World
    {
        public int rows = 8, columns = 8;
        public Tile[,] world = null;
        int maxTraps = 0;
        int numOfTraps = 0;


        public World()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns - 1; j++)
                {
                    Random rnd = new Random();
                    if (numOfTraps < maxTraps)
                    {
                        int id = rnd.Next(2, 3);
                        world[i, j] = new Tile(id);
                        numOfTraps++;
                    }

                    if (numOfTraps >= maxTraps)
                    {
                        world[i, j] = new Tile(3);

                    }

                }

            }
        }

        public void SetExit()
        {
            int flag = 0;
            Random rnd = new Random();
            for (int j = 0; j < columns; j++)
            {
                int id = rnd.Next(0, 100);
                if (id <= 60 && flag == 0)
                {
                    world[rows, j] = new Tile(1);
                    flag = 1;
                }
                else if(numOfTraps < maxTraps)
                {
                   id = rnd.Next(2, 3);
                    world[rows, j] = new Tile(id);
                    numOfTraps++;
                }
            }
        }
    }
}
