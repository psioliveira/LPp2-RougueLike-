using System;
using System.Collections.Generic;
using System.Text;

namespace RougueLikeRPG
{
    /// <summary>classe responsável por gerar o mundo do jogo </summary>
    class World
    {
        private int rows = 8, columns = 8;
        public Tile[,] Tworld = new Tile[8, 8];
        public int MaxTraps = 1;
        private int maxMobs = 1;
        private int _numOfMobs = 0;
        private int _numOfTraps = 0;
        public int Lvl;
        public bool map = false;
        Random rnd = new Random(DateTime.Now.Millisecond);


        public int MaxMobs { get => maxMobs; set => maxMobs = value; }

        /// <summary>adiciona o player, mobs, traps e saída </summary>
        public World(int lvl, Player player)
        {
            Lvl = lvl;
            MaxMobs = 1 + (lvl / 4);
            MaxTraps = (int)Math.Pow(Lvl, 0.4f) * 2;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Tworld[i, j] = new Tile(2, lvl);
                }
            }

            SetPlayer(player);
            SetExit();
            SetTrap();
            SetMobs();
            SetMap();
        }

        /// <summary>função que gera a saída </summary>
        public void SetExit()
        {

            int j = rnd.Next(0, 7);
            Tworld[j, columns - 1] = new Tile(1, Lvl);
        }

        /// <summary>função que gera o player </summary>
        public void SetPlayer(Player player)
        {

            int i = rnd.Next(0, 7);
            i = rnd.Next(0, 7);
            Tworld[i, 0] = new Tile(4, Lvl);
            Tworld[i, 0].Stuffs.Add(player);
        }

        /// <summary>metodo que adiciona os mobs </summary>
        public void SetMobs()
        {
            while (_numOfMobs < MaxMobs)
            {

                int i = rnd.Next(0, 7);
                int j = rnd.Next(0, 7);
                if (Tworld[i, j].IdTile == 2 && _numOfMobs < MaxMobs)
                {
                    _numOfMobs += Tworld[i, j].SortMobs();
                }
            }

        }

        /// <summary>metodo que adiciona o mapa </summary>
        public void SetMap()
        {
            while (!map)
            {

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

        /// <summary>metodo que adiciona as traps </summary>
        public void SetTrap()
        {
            while (_numOfTraps < MaxTraps)
            {

                int i = rnd.Next(0, 7);
                int j = rnd.Next(0, 7);
                if (Tworld[i, j].IdTile == 2 && _numOfTraps < MaxTraps)
                {
                    _numOfTraps += Tworld[i, j].SortTraps();
                }
            }
        }

    }
}
