using System;
using System.Collections;
using System.Collections.Generic;

namespace RougueLike
{
    class Tile
    {
        public int damage = 0;
        private int maxDamage = 99;
        string Name { get; set; } = "";
        private bool visible = false;
        private Bag bag = new Bag();
        private int idTile = 0;
        private int lvl;
        private ArrayList stuffs = new ArrayList(5);

        public ArrayList Stuffs { get => stuffs; set => stuffs = value; }
        public int Lvl { get => lvl; set => lvl = value; }
        public int IdTile { get => idTile; set => idTile = value; }
        public Bag Bag { get => bag; set => bag = value; }
        public bool Visible { get => visible; set => visible = value; }

        public Tile(int id, int lvl)
        {
            Lvl = lvl;
            TileType(id);
            IdTile = id;
            SortMobs();
        }

        public void TileType(int id)
        {
            switch (id)
            {
                case 1:
                    Name = "Exit";
                    Visible = true;
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
            int Mobs = rnd.Next(0, MaxMobs);

            for (int i = 0; i < Mobs; i++)
            {
                Mob mb = new Mob(Lvl);
                Stuffs.Add(mb);
            }

        }
    }
}
