using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougueLike
{
    class World
    {
        private int rows = 8, columns = 8;
        public Tile[,] Tworld = new Tile[8,8];
        private int _maxTraps = 0;
        private int _numOfTraps = 0;
        public int Lvl;

        int MaxTraps
        {
            get => _maxTraps; set => _maxTraps = (int)Math.Pow(Lvl, 0.4f);
        }


        public World(int lvl)
        {
            Lvl = lvl;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Random rnd = new Random();


                    if (_numOfTraps < MaxTraps)
                    {
                        int id = rnd.Next(2, 3);
                        Tworld[i, j] = new Tile(id, lvl);

                        if (id == 3)
                            _numOfTraps++;

                    }

                    if (_numOfTraps >= MaxTraps)
                    {
                        Tworld[i, j] = new Tile(3, lvl);

                    }
                }
            }

            SetExit();
        }

        public void SetExit()
        {
            Random rnd = new Random();
            int j = rnd.Next(0, 7);
            Tworld[j, columns - 1] = new Tile(1, Lvl);
        }

        public Tile[,] GetWorld()
        {
            return Tworld;
        }
    }
}
