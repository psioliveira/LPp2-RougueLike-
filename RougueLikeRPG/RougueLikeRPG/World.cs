using System;
using System.Collections.Generic;
using System.Text;

namespace RougueLike
{
    class World
    {
        private int rows = 8, columns = 8;
        public Tile[,] Tworld = new Tile[8, 8];
        private int _maxTraps = 0;
        private int maxMobs = 1;
        private int _numOfMobs = 0;
        private int _numOfTraps = 0;
        public int Lvl;
        public bool map = false;

        int MaxTraps
        {
            get => _maxTraps; set => _maxTraps = (int)Math.Pow(Lvl, 0.4f);
        }
        public int MaxMobs { get => maxMobs; set => maxMobs = value; }

        public World(int lvl, Player player)
        {
            Lvl = lvl;
            MaxMobs = 1 + (lvl / 4);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Random rnd = new Random(DateTime.Now.Millisecond);


                    if (_numOfTraps < MaxTraps)
                    {
                        int id = rnd.Next(2, 3);
                        Tworld[i, j] = new Tile(id, lvl);

                        if (id == 3)
                            _numOfTraps++;
                    }

                    if (_numOfTraps == MaxTraps)
                    {
                        Tworld[i, j] = new Tile(2, lvl);
                    }
                }
            }

            SetPlayer(player);
            SetExit();
            SetMobs();
            SetMap();
        }

        public void SetExit()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            int j = rnd.Next(0, 7);
            Tworld[j, columns - 1] = new Tile(1, Lvl);
        }

        public void SetPlayer(Player player)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            int i = rnd.Next(0, 7);
            i = rnd.Next(0, 7);
            Tworld[i, 0] = new Tile(4, Lvl);
            Tworld[i, 0].Stuffs.Add(player);
        }

        public void SetMobs()
        {
            while (_numOfMobs < MaxMobs)
            {
                Random rnd = new Random(DateTime.Now.Millisecond);
                int i = rnd.Next(0, 7);
                int j = rnd.Next(0, 7);
                if (Tworld[i, j].IdTile == 2 && _numOfMobs < MaxMobs)
                {
                    _numOfMobs = Tworld[i, j].SortMobs();
                }
            }

        }

        public void SetMap()
        {
            while (!map)
            {
                Random rnd = new Random(DateTime.Now.Millisecond);
                int i = rnd.Next(0, 7);
                int j = rnd.Next(0, 7);
                if (Tworld[i, j].IdTile == 2 && map == false)
                {
                    Map m = new Map();
                    Tworld[i, j].Stuffs.Add(m);
                    map = true;
                }
            }
        }
    }
}
