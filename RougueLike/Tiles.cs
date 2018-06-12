using System;
using System.Collections.Generic;

namespace RougueLike
{
    class Tile
    {
        public int damage = 0;
        private int maxDamage = 99;
        string Name { get; set; } = "";
        bool visible = false;
        public Bag bag = new Bag();
        private int idTile = 0;
        public int lvl;

        public List<IAlive> stuffs;
        public Tile(int id, int lvl)
        {
            this.lvl = lvl;
            TileType(id);
            idTile = id;
            SortMobs();
        }

        public void TileType(int id)
        {
            switch (id)
            {
                case 1:
                    Name = "Exit";
                    visible = true;
                    break;

                case 2:
                    Name = "Grass";
                    SortMobs();
                    break;

                case 3:
                    Name = "Trap";
                    Random rnd = new Random();
                    damage = rnd.Next(0, maxDamage);
                    break;

                default:
                    break;
            }
        }

        void SortMobs()
        {
            int MaxMobs = 5;
            Random rnd = new Random();
            int Mobs = rnd.Next(0,MaxMobs);
            if (idTile == 2)
            {
                for (int i = 0; i < Mobs; i++)
                {
                    Mob mb = new Mob(lvl);
                    stuffs.Add(mb);
                }
            }
        }
    }
}
