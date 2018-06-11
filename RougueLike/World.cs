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
                for (int j = 0; j < columns; j++)
                {
                    Random rnd = new Random();
                    if (numOfTraps < maxTraps)
                    {
                        int id = rnd.Next(2, 3);
                        world[i, j] = new Tile(id);

                        if (id == 3)
                            numOfTraps++;

                    }

                    if (numOfTraps >= maxTraps)
                    {
                        world[i, j] = new Tile(3);

                    }
                }
            }

            SetExit();
        }

        public void SetExit()
        {
            Random rnd = new Random();
            int j = rnd.Next(0, 7);
            world[j, columns - 1] = new Tile(1);
        }
    }
}
