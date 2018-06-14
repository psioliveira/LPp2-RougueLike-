using System;
using System.Collections;
using System.Collections.Generic;

namespace RougueLike
{
    class Tile
    {
        public int damage = 0;
        private int maxDamage = 99;
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
            Random rnd = new Random();
            Lvl = lvl;
            TileType(id, rnd);
            IdTile = id;
            
        }

        public void TileType(int id,Random rnd)
        {
            switch (id)
            {
                case 1: // exit
                    
                    Visible = true;
                    stuffs = new ArrayList(1);
                    break;

                case 2: //grass
                    
                    SortMobs(rnd.Next(),rnd);
                    break;

                case 3: //trap
                    
                    damage = rnd.Next(0, maxDamage);
                    break;

                case 4: //player spawn
                    
                    Visible = true;
                    break;

                default:
                    break;
            }
        }

        void SortMobs(int chance, Random rnd )
        {
            int MaxMobs = 5;

            if ((chance % 100) <= (20 + lvl / 4))
            {
                int Mobs = rnd.Next(0, MaxMobs);

                for (int i = 0; i <= Mobs; i++)
                {
                    int id = rnd.Next(1, 5);
                    Mob mb = new Mob(Lvl, id);
                    stuffs.Add(mb as Mob);
                }
            }


        }
    }
}
