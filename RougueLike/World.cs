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
                    if (numOfTraps == maxTraps)
                    {
                        int id = rnd.Next(0, 3);
                        world[i, j] = new Tile(id);

                    }
                }

            }

            void SetExit()
            {

            }

        }
    }
}
